using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.DTOModel;
using BrightIdeasSoftware;


namespace ReferenceInfoControl
{
    public partial class GeneralReferenceInformation : UserControl
    {
        public Services services;
        public SelectedItem selectedItem = new SelectedItem();
        private int userid=-1;
        public EventHandler SetUser;

        public int UserId
        {
            get
            {
                if (SetUser != null)
                {
                    SetUser(this, null);
                }
                return userid;

            }
            set
            {
                if (DesignMode)
                    return;
                userid = value;
                label1.Text = services.GetAuthor(value);
            }
        }

        public GeneralReferenceInformation()
        {
            if (DesignMode)
                return;            
            InitializeComponent();
            services = new Services();

        }

        public void LoadDocs(int mode,int id)
        {
            LoadTab(mode);
            if (mode == 1)
            {
                LoadDocuments(id, new ObjectsDTO().GetType());
            }
            if (mode == 2)
            {
                LoadDocuments(id, new SectorsDTO().GetType());
            }
            if (mode == 3)
            {
                LoadDocuments(id, new WellsDTO().GetType());
            }
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

            objectListView1.Font = new Font("Arial", 15.5F, GraphicsUnit.Pixel);

            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(128, Color.Aqua), 2);
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 4.0f;

            // Put the decoration onto the hot item
            this.objectListView1.HotItemStyle = new HotItemStyle();
            this.objectListView1.HotItemStyle.Decoration = rbd;
            objectListView1.AlternateRowBackColor = Color.LightGoldenrodYellow;

            //      objectListView1.Heade
            this.objectListView1.CellToolTipShowing += olv_CellToolTipShowing;
            this.objectListView2.CellToolTipShowing += olv_CellToolTipShowing2;
            TextOverlay textOverlay = this.objectListView1.EmptyListMsgOverlay as TextOverlay;
            textOverlay.TextColor = Color.Firebrick;
            textOverlay.BackColor = Color.AntiqueWhite;
            textOverlay.BorderColor = Color.DarkRed;
            textOverlay.BorderWidth = 4.0f;
            textOverlay.Font = new Font("Chiller", 36);
            textOverlay.Rotation = -5;
            objectListView1.Refresh();
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
            objectListView2.AllColumns[0].FillsFreeSpace = true;
            objectListView2.AllColumns[1].FillsFreeSpace = true;
            objectListView2.AllColumns[2].FillsFreeSpace = true;
            objectListView2.AllColumns[3].FillsFreeSpace = true;
            objectListView2.AllColumns[4].FillsFreeSpace = true;
            LoadTab(1);
        }

        private void olv_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            if (objectListView1.SelectedItem != null &&
                objectListView1.HotRowIndex == objectListView1.SelectedItem.Index)
                e.Text = Services.GetItemAsString(objectListView1.SelectedObject);
            //       objectListView1.Items[objectListView1.HotRowIndex].Focused = true;
            //            if (objectListView1.FocusedObject!= null)
            //        e.Text =Services.GetItemAsString( objectListView1.FocusedObject);
            //      objectListView1.Items[objectListView1.HotRowIndex].Focused = false;

            objectListView2.CellToolTip.IsBalloon = true;
            objectListView2.CellToolTip.Font = new Font("Tahoma", 14);
        }

        private void olv_CellToolTipShowing2(object sender, ToolTipShowingEventArgs e)
        {
            if (objectListView2.SelectedObjects.Count > 1)
                return;
            e.Text = Services.GetItemAsString(e.Item.RowObject);
            objectListView1.CellToolTip.IsBalloon = true;
            objectListView1.CellToolTip.Font = new Font("Tahoma", 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.objectListView1, typeof(ObjectsDTO), true);
            objectListView1.AllColumns[1].FillsFreeSpace = true;
            objectListView1.SetObjects(services.GetObjects());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.objectListView1, typeof(SectorsDTO), true);
            objectListView1.AllColumns[1].FillsFreeSpace = true;
            objectListView1.AllColumns[2].FillsFreeSpace = true;
            objectListView1.SetObjects(services.GetSectors());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Generator.GenerateColumns(this.objectListView1, typeof(WellsDTO), true);
            objectListView1.SetObjects(services.GetWells());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            this.objectListView1.ModelFilter = null;
            var text = textBox1.Text;
            var searchWords = text.Split(';');
            var filters = new List<IModelFilter>();
            searchWords = searchWords.Reverse().ToArray();
            foreach (var word in searchWords)
            {
                filters.Add(TextMatchFilter.Contains(this.objectListView1, word));
            }
            this.objectListView1.ModelFilter = new CompositeAllFilter(filters);

            objectListView1.Refresh();
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
            selectedItem.SetItem(objectListView1.SelectedItem.RowObject);
            //     MessageBox.Show(selectedItem.Id.ToString(),selectedItem.item.GetType().Name);
            tabControl1.SelectedIndex = 1;
            LoadDocuments();
            objectListView2.Refresh();
            label2.Text = services.GetItemsPath(objectListView1.SelectedObject);
        }

        private void objectListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                objectListView1_MouseDoubleClick(objectListView1, null);
        }

        public void LoadDocuments()
        {
            objectListView2.SetObjects(services.GetDocuments(selectedItem.Id, selectedItem.item.GetType(), UserId));
            //for (int i = 0; i < objectListView2.Items.Count; i++)
            //{
            //    objectListView2.Items[i].ForeColor=Color.Blue;
            //}            
            objectListView2.Refresh();
        }

        public void LoadDocuments(int id,Type type)
        {
            objectListView2.SetObjects(services.GetDocuments(id, type, UserId));
            objectListView2.Refresh();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                this.objectListView1.ModelFilter = null;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            panel1.Visible = false;
        }

        private void objectListView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(Services.GetItemAsString(objectListView2.SelectedObjects[0]));
        }

        private void button2_Click_1(object sender, EventArgs e)
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
                        services.AddFile(shortName, UserId, "1", bytes, selectedItem.Id, true, true, selectedItem.item.GetType());
                    }
                    LoadDocuments();
                }
            }
            //     new AddFileForm(this).ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                objectListView2.ShowGroups = true;
                objectListView2.BuildGroups();
            }
            else
            {
                objectListView2.ShowGroups = false;
                objectListView2.BuildGroups();
            }
            objectListView2.Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearOpened();
            for (int i = 0; i < objectListView2.SelectedItems.Count; i++)
            {
                var doc = objectListView2.SelectedObjects[i] as DocumentsDTO;
                var guid = Guid.NewGuid();
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/Opened/" + guid.ToString());
                var data = services.GetDocumentByid(doc.id, selectedItem.item.GetType());
                File.WriteAllBytes(Environment.CurrentDirectory + "/Opened/" + guid.ToString() + "/" + doc.Name, data);
                Process.Start(Environment.CurrentDirectory + "/Opened/" + guid.ToString() + "/" + doc.Name);
            }
            // LoadDocuments();
        }

        private void objectListView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (checkBox1.Checked && objectListView2.OLVGroups != null)
            {
                for (int i = 0; i < objectListView2.OLVGroups.Count; i++)
                {
                    objectListView2.OLVGroups[i].Collapsed = true;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objectListView2.SelectedItems.Count; i++)
            {
                services.DeleteFile((objectListView2.SelectedObjects[i] as DocumentsDTO).id, selectedItem.item.GetType());
            }
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
            if (e.KeyCode == Keys.Back && objectListView2.Focused)
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.objectListView2.ModelFilter = null;
            var text = textBox2.Text;
            var searchWords = text.Split(';');
            var filters = new List<IModelFilter>();
            searchWords = searchWords.Reverse().ToArray();
            foreach (var word in searchWords)
            {
                filters.Add(TextMatchFilter.Contains(this.objectListView2, word));
            }
            this.objectListView2.ModelFilter = new CompositeAllFilter(filters);
            objectListView2.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                objectListView2.View = View.Tile;
                objectListView2.CalculateReasonableTileSize();
            }
            else
            {
                objectListView2.View = View.Details;
            }
            objectListView2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<int> newDocs = new List<int>();
            for (int i = 0; i < objectListView2.SelectedItems.Count; i++)
            {
                var doc = objectListView2.SelectedObjects[i] as DocumentsDTO;
                var data = services.GetDocumentByid(doc.id, selectedItem.item.GetType());
                services.AddFile(doc.Name, UserId, doc.Version + "_Cloned", data, selectedItem.Id, true, true, selectedItem.item.GetType());
                LoadDocuments();
            }
        }

        private void objectListView2_SelectionChanged(object sender, EventArgs e)
        {
            if (objectListView2.SelectedObjects.Count == 0)
            {
                panel1.Visible = false;
                panel2.Enabled = false;
            }
            else
                if (objectListView2.SelectedObjects.Count == 1)
            {
                var doc = objectListView2.SelectedObjects[0] as DocumentsDTO;
                if (doc.Author != UserId && !services.IsAdmin(UserId))
                {
                    panel1.Visible = false;
                    button5.Enabled = false;
                }
                else
                {
                    panel1.Visible = true;
                    button5.Enabled = true;
                }

                if (/*services.UserCanEditData(UserId) ||*/ services.IsAdmin(UserId) || doc.Author == UserId || doc.UsersCanEdit)
                {
                    button7.Enabled = true;

                }
                else
                {
                    button7.Enabled = false;
                }
                if (doc.BeingEdited && doc.UserThatEdits != null && (doc.UserThatEdits.Value == UserId))
                {
                    panel2.Enabled = true;
                    button7.Enabled = false;
                }
                else
                {
                    panel2.Enabled = false;
             //       button7.Enabled = true;

                }
                textBox3.Text = doc.Name;
                textBox4.Text = doc.Version;
                radioButton2.Checked = true;
                if (doc.UsersCanEdit)
                {
                    radioButton1.Checked = true;
                }
                if (doc.IsPrivate)
                {
                    radioButton3.Checked = true;
                }
            }
            else
            {
                button5.Enabled = false;
                panel2.Enabled = false;
                panel1.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var doc = objectListView2.SelectedObjects[0] as DocumentsDTO;

            doc.Name = textBox3.Text;
            doc.Version = textBox4.Text;
            if (radioButton1.Checked)
            {
                doc.IsPrivate = false;
                doc.UsersCanEdit = true;
            }
            else
           if (radioButton2.Checked)
            {
                doc.IsPrivate = false;
                doc.UsersCanEdit = false;
            }
            else
           if (radioButton3.Checked)
            {
                doc.IsPrivate = true;
                doc.UsersCanEdit = true;
            }
            services.EditDocument(doc, selectedItem.item.GetType());
            panel1.Visible = false;
            LoadDocuments();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            var doc = objectListView2.SelectedObjects[0] as DocumentsDTO;
            if (doc.BeingEdited && doc.UserThatEdits != null && (doc.UserThatEdits.Value != UserId))
            {
                MessageBox.Show("Файл уже редактируется пользователем: " + services.GetAuthor(doc.UserThatEdits.Value));
                return;
            }
            doc.BeingEdited = true;
            doc.UserThatEdits = UserId;
            services.EditDocument(doc, selectedItem.item.GetType());
            var path = selectedItem.item.GetType().Name + "/" + doc.id + "/";
            System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "/Edited/" + path.ToString());
            var data = services.GetDocumentByid(doc.id, selectedItem.item.GetType());
            File.WriteAllBytes(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name, data);
            Process.Start(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)

        {
            var doc = objectListView2.SelectedObjects[0] as DocumentsDTO;
            doc.UserThatEdits = null;
            doc.LastChangeUser = UserId;
            var path = selectedItem.item.GetType().Name + "/" + doc.id + "/";
            var data = File.ReadAllBytes(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
            File.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
            System.IO.Directory.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString());
            panel2.Enabled = false;
            button7.Enabled = true;
            services.SetNewDocData(doc, selectedItem.item.GetType(), data);
            LoadDocuments();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var doc = objectListView2.SelectedObjects[0] as DocumentsDTO;
            doc.BeingEdited = false;
            doc.UserThatEdits = null;
            services.EditDocument(doc, selectedItem.item.GetType());
            var path = selectedItem.item.GetType().Name + "/" + doc.id + "/";
            File.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString() + "/" + doc.Name);
            System.IO.Directory.Delete(Environment.CurrentDirectory + "/Edited/" + path.ToString());
            panel2.Enabled = false;
            button7.Enabled = true;
            LoadDocuments();
        }

        private void ClearOpened()
        {
            String[] allfiles = System.IO.Directory.GetFiles(Environment.CurrentDirectory + "/Opened/", "*.*",
                System.IO.SearchOption.AllDirectories);
            System.IO.Directory.GetDirectories(Environment.CurrentDirectory + "/Opened/");
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

        bool CanReadFile(string fileName)
        {
            try
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open))
                {
                    // File/Stream manipulating code here
                }
                return true;
            }
            catch
            {
                return false;
            }
         
        }
    }
}
