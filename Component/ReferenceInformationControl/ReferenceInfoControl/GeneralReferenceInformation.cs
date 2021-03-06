﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Contract.DTOModel;
using BrightIdeasSoftware;
using ReferenceInfoControl.ServiceReference;
using DocumentsDTO = BLL.Contract.DTOModel.DocumentsDTO;
using ObjectsDTO = BLL.Contract.DTOModel.ObjectsDTO;
using SectorsDTO = BLL.Contract.DTOModel.SectorsDTO;
using WellsDTO = BLL.Contract.DTOModel.WellsDTO;


namespace ReferenceInfoControl
{
    public partial class GeneralReferenceInformation : UserControl
    {
        public IWcfRemoteService services;
        public SelectedItem selectedParentItem = new SelectedItem();
        private int userid = -1;
        public EventHandler SetUser;
        private readonly SynchronizationContext synchronizationContext;
        public int UserId
        {
            get
            {
                SetUser?.Invoke(this, null);
                return userid;

            }
            set
            {
                if (DesignMode)
                    return;
                userid = value;
                label1.Text = services.GetAuthor(value);
                SetUser = null;
            }
        }

        public GeneralReferenceInformation()
        {
            if (DesignMode)
                return;
            InitializeComponent();
            services = new WcfRemoteServiceClient("BasicHttpBinding_IWcfRemoteService");
            synchronizationContext = SynchronizationContext.Current;
        }

        public void LoadDocs(int mode, int id)
        {
            if (SetUser != null)
            {
                SetUser(this, null);
            }
            if (userid == -1)
            {
                MessageBox.Show("Не удалось получить данные от пользователя\n(Рекомендуеться использовать событие SetUserId для устаовки)");
                return;
            }
            LoadTab(mode);
            if (mode == 1)
            {
                var item = services.GetObjectById(id);
                if (item == null)
                {
                    MessageBox.Show(@"Не удалось открыть документы данного объекта, возможно он не существует!");
                    return;
                }
                LoadDocuments(id, item.GetType());
                selectedParentItem.SetItem(item);
                
            }
            if (mode == 2)
            {
                var item = services.GetSectorById(id);
                if (item == null)
                {
                    MessageBox.Show(@"Не удалось открыть документы данного объекта, возможно он не существует!");
                    return;
                }
                LoadDocuments(id, item.GetType());
                selectedParentItem.SetItem(item);
            }
            if (mode == 3)
            {
                var item = services.GetWellById(id);
                if (item == null)
                {
                    MessageBox.Show(@"Не удалось открыть документы данного объекта, возможно он не существует!");
                    return;
                }
                LoadDocuments(id, item.GetType());
                selectedParentItem.SetItem(item);
            }
            label2.Text = services.GetItemsPath(selectedParentItem.Id, selectedParentItem.item.GetType().Name);
            tabControl1.SelectedIndex = 1;
          
        }
        public void LoadTab(int number)
        {
            if (number == 1)
            {
                button1_Click(objectsButton, null);
            }
            else if (number == 2)
            {
                button2_Click(sectorButton, null);
            }
            else
            {
                button3_Click(wellsButton, null);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            userid = -1;

            generalListView.Font = new Font("Arial", 15.5F, GraphicsUnit.Pixel);

            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(128, Color.Aqua), 2);
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 4.0f;
            this.generalListView.HotItemStyle = new HotItemStyle();
            this.generalListView.HotItemStyle.Decoration = rbd;
            generalListView.AlternateRowBackColor = Color.LightGoldenrodYellow;
            this.generalListView.CellToolTipShowing += generalListView_CellToolTipShowing;
            this.fileListView.CellToolTipShowing += fileListView_CellToolTipShowing2;
            TextOverlay textOverlay = this.generalListView.EmptyListMsgOverlay as TextOverlay;
            textOverlay.TextColor = Color.Firebrick;
            textOverlay.BackColor = Color.AntiqueWhite;
            textOverlay.BorderColor = Color.DarkRed;
            textOverlay.BorderWidth = 4.0f;
            textOverlay.Font = new Font("Chiller", 36);
            textOverlay.Rotation = -5;
            generalListView.Refresh();
            NameColumn.ImageGetter += delegate (object rowObject)
            {
                var ob = rowObject as DocumentsDTO;
                if (ob == null) return 0;
                if (ob.Name.EndsWith(".doc")) return 2;
                if (ob.Name.EndsWith(".docx")) return 3;
                if (ob.Name.EndsWith(".txt")) return 1;
                if (ob.Name.EndsWith(".pdf")) return 5;
                if (ob.Name.EndsWith(".jpeg") || ob.Name.EndsWith(".gif") || ob.Name.EndsWith(".png") ||
                    ob.Name.EndsWith(".jpg"))
                    return 4;
                if (ob.Name.EndsWith(".mp3") || ob.Name.EndsWith(".wav") || ob.Name.EndsWith(".flac")) return 7;
                if (ob.Name.EndsWith(".avi") || ob.Name.EndsWith(".mp4") || ob.Name.EndsWith(".flac")) return 6;
                return 0;
            };
            NameColumn2.ImageGetter += delegate (object rowObject)
            {
                var ob = rowObject as FoundDocumentsDto;
                if (ob == null) return 0;
                if (ob.Name.EndsWith(".doc")) return 2;
                if (ob.Name.EndsWith(".docx")) return 3;
                if (ob.Name.EndsWith(".txt")) return 1;
                if (ob.Name.EndsWith(".pdf")) return 5;
                if (ob.Name.EndsWith(".jpeg") || ob.Name.EndsWith(".gif") || ob.Name.EndsWith(".png") ||
                    ob.Name.EndsWith(".jpg"))
                    return 4;
                if (ob.Name.EndsWith(".mp3") || ob.Name.EndsWith(".wav") || ob.Name.EndsWith(".flac")) return 7;
                if (ob.Name.EndsWith(".avi") || ob.Name.EndsWith(".mp4") || ob.Name.EndsWith(".flac")) return 6;
                return 0;
            };
            fileListView.AllColumns.ForEach(a=>a.FillsFreeSpace=true);
            searchFilesListView.AllColumns.ForEach(a => a.FillsFreeSpace = true);
            LoadTab(1);
        }

        private void generalListView_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            if (generalListView.SelectedItem != null &&
                generalListView.HotRowIndex == generalListView.SelectedItem.Index)
                e.Text = SelectedItem.GetItemAsString(generalListView.SelectedObject);
            fileListView.CellToolTip.IsBalloon = true;
            fileListView.CellToolTip.Font = new Font("Tahoma", 14);
        }

        private void fileListView_CellToolTipShowing2(object sender, ToolTipShowingEventArgs e)
        {
            if (fileListView.SelectedObjects.Count > 1)
                return;
            e.Text = SelectedItem.GetItemAsString(e.Item.RowObject);
            generalListView.CellToolTip.IsBalloon = true;
            generalListView.CellToolTip.Font = new Font("Tahoma", 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.generalListView, typeof(ObjectsDTO), true);
            generalListView.AllColumns[1].FillsFreeSpace = true;
            generalListView.SetObjects(services.GetObjects());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.generalListView, typeof(SectorsDTO), true);
            generalListView.AllColumns[1].FillsFreeSpace = true;
            generalListView.AllColumns[2].FillsFreeSpace = true;
            generalListView.SetObjects(services.GetSectors());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.generalListView, typeof(WellsDTO), true);
            generalListView.SetObjects(services.GetWells());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            this.generalListView.ModelFilter = null;
            var text = textBox1.Text;
            var filters = new List<IModelFilter>();
            TextMatchFilter highlightingFilter = null;
            var words = text.Split(';');
            highlightingFilter = TextMatchFilter.Contains(generalListView, words);
            foreach (var word in words)
            {
                var filter = TextMatchFilter.Contains(generalListView, word);
                filters.Add(filter);
            }

            var compositeFilter = new CompositeAllFilter(filters);

            generalListView.ModelFilter = highlightingFilter;
            generalListView.AdditionalFilter = compositeFilter;
            generalListView.DefaultRenderer = new HighlightTextRenderer(highlightingFilter);
        }

        private void objectListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SetUser != null)
            {
                SetUser(this, null);
            }
            if (userid == -1)
            {
                MessageBox.Show("Не удалось получить данные от пользователя\n(Рекомендуеться использовать событие SetUserId для устаовки)");
                return;
            }
            selectedParentItem.SetItem(generalListView.SelectedItem.RowObject);
            tabControl1.SelectedIndex = 1;
            LoadDocuments();
            fileListView.Refresh();
            label2.Text = services.GetItemsPath(selectedParentItem.Id, selectedParentItem.item.GetType().Name);
            
        }

        private void objectListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                objectListView1_MouseDoubleClick(generalListView, null);
        }

        public void LoadDocuments()
        {
            fileListView.SetObjects(services.GetDocuments(selectedParentItem.Id, selectedParentItem.item.GetType().Name, UserId).OrderBy(a=>a.dateTime));
            fileListView.Refresh();
            FileListView_SelectionChanged(null, null);
        }

        public void LoadDocuments(int parentId, Type type)
        {
            fileListView.SetObjects(services.GetDocuments(parentId, type.Name, UserId));
            fileListView.Refresh();
        }
        private void FilterTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                this.generalListView.ModelFilter = null;
            }
        }



        private void GoBackButtonClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            fileInfoPanel.Visible = false;
        }

        private void objectListView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void AddFileButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var selectFileDialog = new OpenFileDialog()
                {
                    Multiselect = true,
                })
                {
                    if (selectFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        for (int i = 0; i < selectFileDialog.FileNames.Length; i++)
                        {
                            var fileName = selectFileDialog.FileNames[i];

                            var shortName = selectFileDialog.SafeFileNames[i];
                            var bytes = File.ReadAllBytes(fileName);
                            services.AddFile(shortName, UserId, "1", bytes, selectedParentItem.Id, true, true, selectedParentItem.item.GetType().Name);
                        }
                        LoadDocuments();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
            }
        }

        private void GroupsTextBoxCheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fileListView.ShowGroups = true;
                fileListView.BuildGroups();
            }
            else
            {
                fileListView.ShowGroups = false;
                fileListView.BuildGroups();
            }
            fileListView.Refresh();
        }

        private void OpenButtonClick(object sender, EventArgs e)
        {
            ClearOpened();
            for (int i = 0; i < fileListView.SelectedItems.Count; i++)
            {
                try
                {
                    var doc = fileListView.SelectedObjects[i] as DocumentsDTO;
                    var guid = Guid.NewGuid();
                    System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/Opened/" + guid.ToString());
                    var data = services.GetDocumentByid(doc.id, selectedParentItem.item.GetType().Name);
                    File.WriteAllBytes(Environment.CurrentDirectory + "/Opened/" + guid.ToString() + "/" + doc.Name, data);
                    Process.Start(Environment.CurrentDirectory + "/Opened/" + guid.ToString() + "/" + doc.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
                }
            }
        }

        private void FileListColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (checkBox1.Checked && fileListView.OLVGroups != null)
            {
                for (int i = 0; i < fileListView.OLVGroups.Count; i++)
                {
                    fileListView.OLVGroups[i].Collapsed = true;
                }
            }

        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListView.SelectedItems.Count; i++)
            {
                try
                {
                    var doc = (fileListView.SelectedObjects[i] as DocumentsDTO);
                    if (!services.IsAdmin(userid) && doc.Author != userid) continue;
                    services.DeleteFile(doc.id, selectedParentItem.item.GetType().Name);

                    var path = selectedParentItem.item.GetType().Name + "/" + doc.id;
                    if (File.Exists(Environment.CurrentDirectory + "/Edited/" + path + "/" + doc.Name))
                    {
                        File.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
                        System.IO.Directory.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
                }
            }
            fileInfoPanel.Visible = false;
            LoadDocuments();
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                if (tabControl1.SelectedIndex == 1)
                    tabControl1.SelectedIndex = 1;
                else
                {
                    e.Handled = true;
                }
            }
            if (e.KeyCode == Keys.Back && fileListView.Focused)
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void FileFilterTextBoxTextChanged(object sender, EventArgs e)
        {
            this.fileListView.ModelFilter = null;
            var text = textBox2.Text;
            var filters = new List<IModelFilter>();
            TextMatchFilter highlightingFilter = null;
            var words = text.Split(';');
            highlightingFilter = TextMatchFilter.Contains(fileListView, words);
            foreach (var word in words)
            {
                var filter = TextMatchFilter.Contains(fileListView, word);
                filters.Add(filter);
            }

            var compositeFilter = new CompositeAllFilter(filters);

            fileListView.ModelFilter = highlightingFilter;
            fileListView.AdditionalFilter = compositeFilter;
            fileListView.DefaultRenderer = new HighlightTextRenderer(highlightingFilter);
        }

        private void TileCheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fileListView.View = View.Tile;
                fileListView.CalculateReasonableTileSize();
            }
            else
            {
                fileListView.View = View.Details;
            }
            fileListView.Refresh();
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListView.SelectedItems.Count; i++)
            {
                try
                {
                    var doc = fileListView.SelectedObjects[i] as DocumentsDTO;
                    var data = services.GetDocumentByid(doc.id, selectedParentItem.item.GetType().Name);
                    services.AddFile(doc.Name, UserId, doc.Version + "_Cloned", data, selectedParentItem.Id, true, true,
                        selectedParentItem.item.GetType().Name);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
                }
            }
            LoadDocuments();
        }

        private void FileListView_SelectionChanged(object sender, EventArgs e)
        {
            uploadButton.Enabled = true;
            editButton.Enabled = false;
            if (fileListView.SelectedObjects.Count == 0)
            {
                fileInfoPanel.Visible = false;
                editPanel.Enabled = false;
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                cloneButton.Enabled = false;
                openButton.Enabled = false;
            }
            else
                if (fileListView.SelectedObjects.Count == 1)
            {
                cloneButton.Enabled = true;
                openButton.Enabled = true;
                var doc = fileListView.SelectedObjects[0] as DocumentsDTO;
                if (doc.Author != UserId && !services.IsAdmin(UserId))
                {
                    fileInfoPanel.Visible = false;
                    deleteButton.Enabled = false;
                }
                else
                {
                    fileInfoPanel.Visible = true;
                    deleteButton.Enabled = true;
                }

                if (/*services.UserCanEditData(UserId) ||*/ services.IsAdmin(UserId) || doc.Author == UserId || doc.UsersCanEdit)
                {
                    editButton.Enabled = true;

                }
                else
                {
                    editButton.Enabled = false;
                }
                if (doc.BeingEdited && doc.UserThatEdits != null && (doc.UserThatEdits.Value == UserId))
                {
                    editPanel.Enabled = true;
                    editButton.Enabled = false;
                }
                else
                {
                    editPanel.Enabled = false;
                }
                fileNameTextBox.Text = doc.Name;
                fileVersionTextBox.Text = doc.Version;
                readonlyRadioButton.Checked = true;
                if (doc.UsersCanEdit)
                {
                    chengedRadioButton.Checked = true;
                }
                if (doc.IsPrivate)
                {
                    privateRadioButton.Checked = true;
                }
                if (services.IsAdmin(UserId) && doc.BeingEdited && doc.UserThatEdits != null && (doc.UserThatEdits.Value != UserId))
                {
                    editPanel.Enabled = true;
                    editButton.Enabled = false;
                    uploadButton.Enabled = false;
                }
            }
            else
            {
                cloneButton.Enabled = true;
                openButton.Enabled = true;
                deleteButton.Enabled = true;
                editPanel.Enabled = false;
                fileInfoPanel.Visible = false;
            }
        }

        private void SaveEditPanelClick(object sender, EventArgs e)
        {
            try
            {
                var doc = fileListView.SelectedObjects[0] as DocumentsDTO;

                doc.Name = fileNameTextBox.Text;
                doc.Version = fileVersionTextBox.Text;
                if (chengedRadioButton.Checked)
                {
                    doc.IsPrivate = false;
                    doc.UsersCanEdit = true;
                }
                else if (readonlyRadioButton.Checked)
                {
                    doc.IsPrivate = false;
                    doc.UsersCanEdit = false;
                }
                else if (privateRadioButton.Checked)
                {
                    doc.IsPrivate = true;
                    doc.UsersCanEdit = true;
                }
                services.EditDocument(doc, selectedParentItem.item.GetType().Name);
                fileInfoPanel.Visible = false;
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
            }
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            try
            {
                var doc = fileListView.SelectedObjects[0] as DocumentsDTO;
                if (doc.BeingEdited && doc.UserThatEdits != null && (doc.UserThatEdits.Value != UserId))
                {
                    MessageBox.Show("Файл уже редактируется пользователем: " +
                                    services.GetAuthor(doc.UserThatEdits.Value));
                    return;
                }
                doc.BeingEdited = true;
                doc.UserThatEdits = UserId;
                services.EditDocument(doc, selectedParentItem.item.GetType().Name);
                var path = selectedParentItem.item.GetType().Name + "/" + doc.id + "/";
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/Edited/" + path.ToString());
                var data = services.GetDocumentByid(doc.id, selectedParentItem.item.GetType().Name);
                File.WriteAllBytes(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name, data);
                Process.Start(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
                editButton.Enabled = false;
                editPanel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
            }
        }

        private void UploadButtonClick(object sender, EventArgs e)

        {
            try
            {
                var doc = (fileListView.SelectedObjects[0] as DocumentsDTO);
                doc.UserThatEdits = null;
                doc.LastChangeUser = UserId;
                var path = selectedParentItem.item.GetType().Name + "/" + doc.id + "/";
                var data =
                    File.ReadAllBytes(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
                File.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
                System.IO.Directory.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString());
                services.SetNewDocData(doc, selectedParentItem.item.GetType().Name, data);
                editPanel.Enabled = false;
                editButton.Enabled = true;
                LoadDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!\nИнформация: " + ex.Message);
                fileInfoPanel.Enabled = false;
                editPanel.Enabled = false;
                deleteButton.Enabled = false;
                LoadDocuments();
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            try
            {
                var doc = fileListView.SelectedObjects[0] as DocumentsDTO;
                doc.BeingEdited = false;
                doc.UserThatEdits = null;
                services.EditDocument(doc, selectedParentItem.item.GetType().Name);
                var path = selectedParentItem.item.GetType().Name + "/" + doc.id + "/";
                try
                {
                    File.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
                    System.IO.Directory.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString());
                }
                catch
                {
                }
                editPanel.Enabled = false;
                editButton.Enabled = true;
                LoadDocuments();
            }
            catch { }
        }

        private void ClearOpened()
        {
            try
            {
                String[] allfiles = System.IO.Directory.GetFiles(Environment.CurrentDirectory + "/Opened/", "*.*",
                    System.IO.SearchOption.AllDirectories);
                foreach (var file in allfiles)
                {
                    try
                    {
                        if (CanReadFile(file)) File.Delete(file);
                    }
                    catch
                    {
                    }
                }
                var dirs = System.IO.Directory.GetDirectories(Environment.CurrentDirectory + "/Opened/");
                foreach (var dir in dirs)
                {
                    try
                    {
                        System.IO.Directory.Delete(dir);
                    }
                    catch
                    {
                    }
                }
            }
            catch { }
        }

        bool CanReadFile(string fileName)
        {
            try
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open))
                {
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        private ToolTip tt;

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tt != null)
            {
                tt.Dispose();
            }
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = false;
            tt.Show(string.Empty, textBox1);
            tt.UseAnimation = true;
            tt.Show("Фильтр\nИспользуйте ; для фильтрации нескольких параметров\nПример: Зона;12;используется ", textBox1, 0);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            tt.Dispose();
        }

        private void ExtendedSearch_Click(object sender, EventArgs e)
        {
            var files = services.FoundDocs(userid, ExtendedSearchField.Text).OrderBy(a=>a.dateTime);
            searchFilesListView.SetObjects(files);
            listBox1.Hide();
            searchFilesListView.Refresh();
        }

        private async void ExtendedSearchField_TextChanged(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            if (tb.Text.Length > 0 && ExtendedSearchField.Text != listBox1.SelectedItem?.ToString())
            {
                await Task.Run(() =>
                {
                    var hints = services.GetHints(userid, tb.Text).ToArray();

                    synchronizationContext.Post(new SendOrPostCallback(o =>
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.AddRange((string[])o);
                        listBox1.Show();
                    }), hints);


                });

            }
            else
            {
                listBox1.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is string)
            {
                ExtendedSearchField.Text = listBox1.SelectedItem.ToString();
            }
            listBox1.Hide();
        }

        private void searchFilesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var doc = searchFilesListView.SelectedObjects[0] as FoundDocumentsDto;
                int mode = 1;
                switch (doc.Type)
                {
                    case "ObjectsDTO":
                        mode = 1;
                        break;
                    case "SectorsDTO":
                        mode = 2;
                        break;
                    case "WellsDTO":
                        mode = 3;
                        break;
                }
                LoadDocs(mode, doc.ParentId);

                var index = fileListView.Objects.Cast<DocumentsDTO>().ToList().FindIndex(a => a.id == doc.id);
                fileListView.SelectedIndex = index;
                fileListView.FocusedItem = fileListView.SelectedItems[0];
            }
            catch { }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }
    }
}
