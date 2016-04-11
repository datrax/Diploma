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

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = true;
            unitOfWork = new UnitOfWork<EFModel>();
            listView1.View = View.Tile;
            listView1.TileSize = new Size(200, 45);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

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
            ListViewItem item2 = new ListViewItem(new string[]
            {
                "Programming Windows with C#",
                "Petzold, Charles",
                "2001"
            }, 0);
            ListViewItem item3 = new ListViewItem(new string[]
            {
                "Coding Techniques for Microsoft Visual Basic .NET",
                "Connell, John",
                "2001"
            }, 0);
            ListViewItem item4 = new ListViewItem(new string[]
            {
                "C# for Java Developers",
                "Jones, Allen & Freeman, Adam",
                "2002"
            }, 0);
            ListViewItem item5 = new ListViewItem(new string[]
            {
                "Microsoft .NET XML Web Services Step by Step",
                "Jones, Allen & Freeman, Adam",
                "2002"
            }, 0);
            listView1.Items.AddRange(
                new ListViewItem[] {item0, item1, item2, item3, item4, item5});
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
                unitOfWork.GetRepository<objects>().GetAll().ToList().Select(a => new {Имя = a.name}).ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 40;
            }
        }
    }
}
