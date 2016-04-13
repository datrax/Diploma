using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BrightIdeasSoftware;
using DAL;
using DAL.EF;

namespace Diploma
{
    public partial class Form1 : Form
    {
        private IUnitOfWork unitOfWork = null;
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(new SolidBrush(Color.FromArgb(255, 51, 153, 255)), e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Arial", 20.5F, GraphicsUnit.Pixel);
            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        public Form1()
        {

            InitializeComponent();
            unitOfWork = new UnitOfWork<ModelContext>();
            panel1.SendToBack();
            tabControl1.TabPages[0].Text = ("Объекты");
            tabControl1.TabPages[1].Text = ("Участки");
            tabControl1.TabPages[2].Text = ("Скважины");
            tabControl1.TabPages[3].Text = ("Прочее");
            tabControl1.DrawItem += tabControl1_DrawItem;


            /////////////////////////////////////////////////////////////////////
            listView1.View = View.Tile;
            listView1.TileSize = new Size(200, 45);

            // Add column headers so the subitems will appear.
            listView1.Columns.AddRange(new ColumnHeader[]
            {new ColumnHeader(), new ColumnHeader(), new ColumnHeader()});

            // Create items and add them to myListView.
            var myImageList = new ImageList();
            using (Icon myIcon = new Icon("Icons/Word.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            using (Icon myIcon = new Icon("Icons/Txt.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            using (Icon myIcon = new Icon("Icons/Common.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            using (Icon myIcon = new Icon("Icons/pdf.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            using (Icon myIcon = new Icon("Icons/img.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            myImageList.ImageSize = new Size(42, 42);
            listView1.LargeImageList = myImageList;
            //////////////////////////////////////////////////////////////////////
            FillObjects();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        /*    var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[0].Tag);
            File.WriteAllBytes(doc.Name, doc.Data);
            Process.Start(doc.Name);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*  var name = "246.docx";
              oldHash = Helper.GetFileHash(name);
              Process.Start(name);
              if (!running)
                  CheckFile(name);*/
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[i].Tag);
                File.WriteAllBytes(doc.Name, doc.Data);
                Process.Start(doc.Name);
            }

        }

        private bool running = false;
        private byte[] oldHash = null;

        private async void CheckFile(string fileName)
        {
            running = true;
            await Task.Run(() =>
            {
                while (true)
                {

                    var hash = Helper.GetFileHash(fileName);
                    if (oldHash != null && hash != null && !hash.SequenceEqual(oldHash))
                    {
                        oldHash = hash;
                        break;
                    }
                    System.Threading.Thread.Sleep(500);

                }
            });
            button2.Enabled = true;
            running = false;
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[0].Tag);
            if (!Helper.CanReadFile(doc.Name))
            {
                MessageBox.Show("Please save and close your edited file first!");
                return;
            }
            doc.Data = File.ReadAllBytes(doc.Name);
            doc.CanEdit = true;
            button2.Enabled = false;
            button4.Enabled = false;
            unitOfWork.GetRepository<sectorsd_documents>().Update(doc);
            unitOfWork.Save();
            File.Delete("Edited/" + doc.Name);
            MessageBox.Show("Saved");
            listView1_ItemSelectionChanged(listView1, null);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var datagrid = sender as DataGridView;
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15.5F, GraphicsUnit.Pixel);
            for (int i = 0; i < datagrid.ColumnCount; i++)
            {
                datagrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                row.Height = 40;
            }
        }


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            informationTextBox.Text = "";
            panel1.SendToBack();
            if (tabControl1.SelectedIndex == 0)
            {
                FillObjects();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                FillSectors();
                sectorsGrid.ClearSelection();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                FillWells();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                panel1.BringToFront();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillSectors();
        }

        private void FillSectorDocuments(int id)
        {
            listView1.Items.Clear();
            var t = unitOfWork.GetRepository<sectorsd_documents>().Find(a => a.SectorId == id).ToList();
            t.ForEach(a =>
            {
                var item = new ListViewItem(new string[]
                {
                    a.Name,
                    a.Author,

                }, SetIcon(a.Name));
                item.Tag = a.id;
                listView1.Items.Add(item);
            });

        }

        private int SetIcon(string name)
        {
            var exten = Path.GetExtension(name);
            switch (exten)
            {
                case ".doc":
                case ".docx": { } return 0;
                case ".txt": { } return 1;
                case ".pdf": { } return 3;
                case ".jpeg":
                case ".gif":
                case ".png":
                case ".jpg": { } return 4;
                default:
                    return 2;

            }

        }
        private int sectorId;
        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                panel1.BringToFront();
                if (grid == sectorsGrid)
                {
                    sectorId = int.Parse(grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    FillSectorDocuments(sectorId);
                    listView1_ItemSelectionChanged(listView1, null);
                }
            }
        }

        private void FillObjects()
        {

            objectsGrid.DataSource =
            unitOfWork.GetRepository<objects>().GetAll().ToList().Select(a => new { Имя = a.name }).ToList();
            objectsGrid.Refresh();
        }

        private void FillSectors()
        {
            sectorsGrid.Rows.Clear();
            if (sectorsGrid.ColumnCount == 0)
            {
                sectorsGrid.Columns.Add("Id", "Id");
                sectorsGrid.Columns.Add("Name", "Имя");
                sectorsGrid.Columns.Add("obj", "Объект");
                sectorsGrid.Columns[0].Visible = false;
            }
            dataGridView1_DataBindingComplete(sectorsGrid, null);
            var t = unitOfWork.GetRepository<sectors>().GetAll().ToList().Where(a => a.name.ToLower().Contains(textBox1.Text.ToLower()) && a.objects.name.ToLower().Contains(textBox2.Text.ToLower())).ToList();
            foreach (var a in t)
            {
                sectorsGrid.Rows.Add(a.id, a.name, a.objects.name);
            }
            sectorsGrid.Refresh();
        }

        private void FillWells()
        {
            wellsGrid.Rows.Clear();
            if (wellsGrid.ColumnCount == 0)
            {
                wellsGrid.Columns.Add("Id", "Id");
                wellsGrid.Columns.Add("Name", "Имя");
                wellsGrid.Columns.Add("Sector", "Участок");
                wellsGrid.Columns.Add("Coords", "Коорд");
                wellsGrid.Columns.Add("Depth", "Глубина");
                wellsGrid.Columns.Add("Note", "Заметка");
                wellsGrid.Columns.Add("Date", "Дата");
                wellsGrid.Columns.Add("IndAlt", "Инд. Выс.");
                wellsGrid.Columns.Add("LevAlt", "Ур. Выс.");
                wellsGrid.Columns.Add("Horizon", "Гор.");
                wellsGrid.Columns.Add("FiltUp", "Фильтр. верх");
                wellsGrid.Columns.Add("FiltDown", "Фильтр. низ");
                wellsGrid.Columns[0].Visible = false;
            }
            var t = unitOfWork.GetRepository<wells>().GetAll().Where(a => a.char_name.ToLower().Contains(extendedTextBox1.Text.ToLower())).ToList();
            foreach (var a in t)
            {
                wellsGrid.Rows.Add(a.id, a.char_name, a.sectors.name, a.coordX + " " + a.coordY, a.depth, a.note, a.date, a.index_altitude, a.level_altitude, a.horizon, a.filter_up, a.filter_down);
            }
            wellsGrid.Refresh();
        }

        private void extendedTextBox1_TextChanged(object sender, EventArgs e)
        {
            FillWells();
        }

        private void sectorsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            informationTextBox.Text = "";
            var grid = sender as DataGridView;
            AddInformationToRichTextbox(informationTextBox, "Объект", grid.Rows[e.RowIndex].Cells[1].Value.ToString());
            AddInformationToRichTextbox(informationTextBox, "Участок", grid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void wellsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            informationTextBox.Text = "";
            var grid = sender as DataGridView;
            var well = unitOfWork.GetRepository<wells>().GetById(long.Parse(grid.Rows[e.RowIndex].Cells[0].Value.ToString()));
            AddInformationToRichTextbox(informationTextBox, "Id", well.id.ToString());
            AddInformationToRichTextbox(informationTextBox, "Объект", well.sectors.objects.name);
            if (!string.IsNullOrWhiteSpace(well.sectors.name))
                AddInformationToRichTextbox(informationTextBox, "Участок", well.sectors.name);
            if (!string.IsNullOrWhiteSpace(well.char_name))
                AddInformationToRichTextbox(informationTextBox, "Скважина", well.char_name);
            AddInformationToRichTextbox(informationTextBox, "Координаты (X;Y)", "(" + well.coordX + ";" + well.coordY + ")");
            if (!string.IsNullOrWhiteSpace(well.note))
                AddInformationToRichTextbox(informationTextBox, "Заметка", well.note);
            if (!string.IsNullOrWhiteSpace(well.date.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Дата", well.date.ToString());
            if (!string.IsNullOrWhiteSpace(well.depth.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Глубина", well.depth.ToString());
            if (!string.IsNullOrWhiteSpace(well.index_altitude.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Инд. Выс.", well.index_altitude.ToString());
            if (!string.IsNullOrWhiteSpace(well.level_altitude.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Ур. Выс.", well.level_altitude.ToString());
            if (!string.IsNullOrWhiteSpace(well.horizon.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Горизонт", well.horizon.ToString());
            if (!string.IsNullOrWhiteSpace(well.filter_up.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Фильтр. верх", well.filter_up.ToString());
            if (!string.IsNullOrWhiteSpace(well.filter_down.ToString()))
                AddInformationToRichTextbox(informationTextBox, "Фильтр. низ", well.filter_down.ToString());
        }

        void AddInformationToRichTextbox(RichTextBox textBox, string category, string str)
        {
            var startIndex = textBox.Text.Length;
            textBox.AppendText(category + ":\n" + str + "\n");
            textBox.SelectionStart = startIndex + 1;
            textBox.SelectionLength = category.Length + 1;

            textBox.Select(startIndex, category.Length + 1);
            textBox.SelectionFont = new System.Drawing.Font("Tahoma", 9);
            textBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var fileName = "";
            var shortName = "";
            using (var selectFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
            })
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < selectFileDialog.FileNames.Length; i++)
                    {
                        fileName = selectFileDialog.FileNames[i];
                        shortName = selectFileDialog.SafeFileNames[i];
                        var bytes = File.ReadAllBytes(fileName);
                        var doc = new sectorsd_documents()
                        {
                            CanEdit = true,
                            Name = shortName,
                            Author = "Author",
                            Data = bytes,
                            SectorId = sectorId
                        };
                        unitOfWork.GetRepository<sectorsd_documents>().Add(doc);
                    }
                    unitOfWork.Save();
                    FillSectorDocuments(sectorId);
                }
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                button1.Enabled = button5.Enabled = true;
                button2.Enabled =
                    button3.Enabled = button4.Enabled = button6.Enabled = button7.Enabled = false;

            }
            else if (listView1.SelectedItems.Count == 1)
            {
                button1.Enabled = button5.Enabled = button7.Enabled = true;
                button2.Enabled =
                    button3.Enabled = button4.Enabled = button6.Enabled = false;

                 string[] Files = Directory.GetFiles("Edited/")
                                     .Select(path => Path.GetFileName(path))
                                     .ToArray();
                var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[0].Tag);
                if (Files.Contains(doc.Name))
                {
                    button2.Enabled = true;
                    button4.Enabled = true;
                    button1.Enabled = button5.Enabled = button7.Enabled = false;
                }
    }
            else
            {
                 button3.Enabled = true;
                button2.Enabled = button1.Enabled = button5.Enabled = button7.Enabled =
                   button4.Enabled = button6.Enabled = false;
            }
        }

        private void DeleteButton_click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[i].Tag);
                unitOfWork.GetRepository<sectorsd_documents>().Delete(doc);
            }
            unitOfWork.Save();
            FillSectorDocuments(sectorId);
        }


        private void EditButton_click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Only one item can be edited");
                return;
            }
            else
            {
                var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[0].Tag);
                if (doc.CanEdit != null && !doc.CanEdit.Value)
                {
                    MessageBox.Show("File is being edited already");
                    return;
                }
                doc.CanEdit = false;
                unitOfWork.GetRepository<sectorsd_documents>().Update(doc);
                unitOfWork.Save();
                button2.Enabled = true;
                button4.Enabled = true;
                File.WriteAllBytes("Edited/"+doc.Name, doc.Data);
                Process.Start(doc.Name);
                listView1_ItemSelectionChanged(listView1, null);
            }
        }

        private void CancelEdit_Click(object sender, EventArgs e)
        {
            var doc = unitOfWork.GetRepository<sectorsd_documents>().GetById((int)listView1.SelectedItems[0].Tag);
            doc.CanEdit = true;
            button2.Enabled = false;
            button4.Enabled = false;
            unitOfWork.GetRepository<sectorsd_documents>().Update(doc);
            unitOfWork.Save();
            File.Delete("Edited/"+doc.Name);
            listView1_ItemSelectionChanged(listView1, null);
        }
    }
}
