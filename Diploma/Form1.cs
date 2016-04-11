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
            tabControl1.TabPages[0].Text=("Объекты");
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
        }

        private void clicks(object sender, MouseEventArgs e)
        {
            var t = (sender as DataGridView).CurrentCell.RowIndex;
       //     MessageBox.Show((sender as DataGridView).Rows[t].Cells[1].Value.ToString());
       panel1.BringToFront();
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
            //button2.Enabled = false;
            dataGridView1.DataSource =
                unitOfWork.GetRepository<objects>().GetAll().ToList().Select(a => new { Имя = a.name }).ToList();
            dataGridView1.Refresh();
            dataGridView3.DataSource =
              unitOfWork.GetRepository<sectors>().GetAll().ToList().Select(a => new { Имя = a.name,Объект=a.objects.name }).ToList();
         //   dataGridView3.Columns[1].Visible = false;
       /*     dataGridView3.Columns.Add("Name", "Имя");
            dataGridView3.Columns.Add("obj", "Объект");
            dataGridView1_DataBindingComplete(dataGridView3, null);
           var t = unitOfWork.GetRepository<sectors>().GetAll().ToList();
            foreach (var a in t)
            {
                dataGridView3.Rows.Add(a.name,a.objects.name);
            }*/
            dataGridView3.Refresh();
            dataGridView4.DataSource =
          unitOfWork.GetRepository<wells>().GetAll().ToList().Select(a => new { Имя = a.char_name, Участок = a.sectors.name,Коорд=a.coordX+" "+a.coordY,Глубина =a.depth,Заметка=a.note }).ToList();
            dataGridView3.Refresh();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var datagrid = sender as DataGridView;
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            panel1.SendToBack();
            button2_Click(null, null);
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.SendToBack();

        }
    }
}
