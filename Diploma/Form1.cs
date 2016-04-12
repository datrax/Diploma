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

            panel1.SendToBack();
            tabControl1.TabPages[0].Text = ("Объекты");
            tabControl1.TabPages[1].Text = ("Участки");
            tabControl1.TabPages[2].Text = ("Скважины");
            tabControl1.TabPages[3].Text = ("Прочее");
            tabControl1.DrawItem += tabControl1_DrawItem;
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Height = 32;
                row.DefaultCellStyle.Font = new Font("Arial", 20.5F, GraphicsUnit.Pixel);
            }
            button2.Enabled = true;
            unitOfWork = new UnitOfWork<EFModel>();
            dataGridView3.MouseDoubleClick += clicks;
            listView1.View = View.Tile;
            listView1.TileSize = new Size(200, 45);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            // dataGridView1.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30;
                row.DefaultCellStyle.Font = new Font("Arial", 32.5F, GraphicsUnit.Pixel);
            }
            dataGridView1.ClearSelection();

            // Add column headers so the subitems will appear.
            listView1.Columns.AddRange(new ColumnHeader[]
            {new ColumnHeader(), new ColumnHeader(), new ColumnHeader()});

            // Create items and add them to myListView.
            var myImageList = new ImageList();
            using (Icon myIcon = new Icon("Word.ico"))
            {
                myImageList.Images.Add(myIcon);
            }
            myImageList.ImageSize = new Size(52, 52);
            listView1.LargeImageList = myImageList;
            ListViewItem item0 = new ListViewItem(new string[]
            {
                "Programming Windows",
                "Petzold, Charles",
                "1998"
            }, 0);
            ListViewItem item1 = new ListViewItem(new string[]
            {
                "Code: The Hidden Language of Computer Hardware and Software",
                "Petzold, Charles",
                "2000"
            }, 0);

            listView1.Items.AddRange(
                new ListViewItem[] { item0, item1 });
            FillObjects();
        }

        private void clicks(object sender, MouseEventArgs e)
        {
            var t = (sender as DataGridView).CurrentCell.RowIndex;
            //     MessageBox.Show((sender as DataGridView).Rows[t].Cells[1].Value.ToString());
            //   panel1.BringToFront();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var name = "246.docx";
            oldHash = Helper.GetFileHash(name);
            Process.Start(name);
            if (!running)
                CheckFile(name);


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

        private void button2_Click(object sender, EventArgs e)
        {  
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
            richTextBox1.Text = "";
            panel1.SendToBack();
            if (tabControl1.SelectedIndex == 0)
            {
                FillObjects();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                FillSectors();
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

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                panel1.BringToFront();
            }
   

        }

        private void FillObjects()
        {

            dataGridView1.DataSource =
            unitOfWork.GetRepository<objects>().GetAll().ToList().Select(a => new { Имя = a.name }).ToList();
            dataGridView1.Refresh();
        }

        private void FillSectors()
        {
            dataGridView3.Rows.Clear();
            if (dataGridView3.ColumnCount == 0)
            {
                dataGridView3.Columns.Add("Name", "Имя");
                dataGridView3.Columns.Add("obj", "Объект");
            }
            dataGridView1_DataBindingComplete(dataGridView3, null);
            var t = unitOfWork.GetRepository<sectors>().GetAll().ToList().Where(a => a.name.ToLower().Contains(textBox1.Text.ToLower()) && a.objects.name.ToLower().Contains(textBox2.Text.ToLower())).ToList();
            foreach (var a in t)
            {
                dataGridView3.Rows.Add(a.name, a.objects.name);
            }
            dataGridView3.Refresh();
        }

        private void FillWells()
        {
            dataGridView4.Rows.Clear();
            if (dataGridView4.ColumnCount == 0)
            {
                dataGridView4.Columns.Add("Name", "Имя");
                dataGridView4.Columns.Add("Sector", "Участок");
                dataGridView4.Columns.Add("Coords", "Коорд");
                dataGridView4.Columns.Add("Depth", "Глубина");
                dataGridView4.Columns.Add("Note", "Заметка");
                dataGridView4.Columns.Add("Date", "Дата");
                dataGridView4.Columns.Add("IndAlt", "Инд. Выс.");
                dataGridView4.Columns.Add("LevAlt", "Ур. Выс.");
                dataGridView4.Columns.Add("Horizon", "Гор.");
                dataGridView4.Columns.Add("FiltUp", "Фильтр. верх");
                dataGridView4.Columns.Add("FiltDown", "Фильтр. низ");
            }
            var t = unitOfWork.GetRepository<wells>().GetAll().Where(a=>a.char_name.ToLower().Contains(extendedTextBox1.Text)).ToList();
            foreach (var a in t)
            {
                dataGridView4.Rows.Add(a.char_name, a.sectors.name,a.coordX+" "+a.coordY,a.depth,a.note,a.date,a.index_altitude,a.level_altitude,a.horizon,a.filter_up,a.filter_down);
            }
            dataGridView4.Refresh();
        }

        private void extendedTextBox1_TextChanged(object sender, EventArgs e)
        {
            FillWells();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = "";
            var grid = sender as DataGridView;
            if (grid == dataGridView3)
            {
                richTextBox1.Text += "Объект:\n" + dataGridView3.Rows[e.RowIndex].Cells[1].Value + "\n" + "Участок:\n" +
                                     dataGridView3.Rows[e.RowIndex].Cells[0].Value;
                   ;
            }
            var length1 = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString().Length;
            var length2 = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString().Length;
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 8; //End of first word
            richTextBox1.SelectionFont = new System.Drawing.Font("Tahoma", 10);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            richTextBox1.SelectionStart = 8+length1;
            richTextBox1.SelectionLength = 8; //End of first word
            richTextBox1.SelectionFont = new System.Drawing.Font("Tahoma", 10);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
          
        }
    }
}
