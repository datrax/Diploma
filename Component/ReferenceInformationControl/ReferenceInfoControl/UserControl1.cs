﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class UserControl1 : UserControl
    {
        Services services = new Services();
        public UserControl1()
        {
            InitializeComponent();
        }

        public void LoadTab(int number)
        {
            if (number == 1)
            {
                button1_Click(objectsButton, null);
            }
            else if (number == 1)
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
                var ob = rowObject as SectorsDocumentsDTO;
                if (ob == null) return 0;
                if (ob.Name.EndsWith(".doc")) return 2;
                if (ob.Name.EndsWith(".docx")) return 3;
                if (ob.Name.EndsWith(".txt")) return 1;
                if (ob.Name.EndsWith(".pdf")) return 5;
                if (ob.Name.EndsWith(".jpeg") || ob.Name.EndsWith(".gif") || ob.Name.EndsWith(".png") || ob.Name.EndsWith(".jpg")) return 4;
                if (ob.Name.EndsWith(".mp3") || ob.Name.EndsWith(".wav") || ob.Name.EndsWith(".flac")) return 7;
                if (ob.Name.EndsWith(".avi") || ob.Name.EndsWith(".mp4") || ob.Name.EndsWith(".flac")) return 6;
                return 0;
            };
            objectListView2.AllColumns[0].FillsFreeSpace = true;
            objectListView2.AllColumns[1].FillsFreeSpace = true;
        }
        void olv_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            if (objectListView1.SelectedItem != null &&
                objectListView1.HotRowIndex == objectListView1.SelectedItem.Index)
                e.Text = Services.GetItemAsString(objectListView1.SelectedObject);
            //       objectListView1.Items[objectListView1.HotRowIndex].Focused = true;
            //            if (objectListView1.FocusedObject!= null)
            //        e.Text =Services.GetItemAsString( objectListView1.FocusedObject);
            //      objectListView1.Items[objectListView1.HotRowIndex].Focused = false;

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

        private void button4_Click(object sender, EventArgs e)
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
            tabControl1.SelectedIndex = 1;

            LoadSectorDocuments();
            objectListView2.Refresh();
        }

        void LoadSectorDocuments()
        {
            objectListView2.SetObjects(services.GetDocuments((objectListView1.SelectedItem.RowObject as SectorsDTO).id));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                this.objectListView1.ModelFilter = null;
            }
        }

        public int UserId { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void objectListView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(objectListView2.SelectedItem.Text);
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
                        services.AddSectorDocument(shortName, "auth", bytes, (objectListView1.SelectedItem.RowObject as SectorsDTO).id);
                    }
                    LoadSectorDocuments();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                objectListView2.ShowGroups = true;
            }
            else
                objectListView2.ShowGroups = false;
            objectListView2.Refresh();
        }
    }
}
