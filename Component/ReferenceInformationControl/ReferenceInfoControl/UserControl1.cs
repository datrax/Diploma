using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
                button3_Click(wellsButton,null);
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
            this.objectListView1.CellToolTipShowing += new EventHandler<ToolTipShowingEventArgs>(olv_CellToolTipShowing);
            objectListView1.Refresh();
        }
        void olv_CellToolTipShowing(object sender, ToolTipShowingEventArgs e)
        {
            // Show a long tooltip over cells only when the control key is down
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
            /* objectListView1.AllColumns[1].FillsFreeSpace = true;
             objectListView1.AllColumns[2].FillsFreeSpace = true;*/
            objectListView1.SetObjects(services.GetWells());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.objectListView1.ModelFilter = null;
            var text = textBox1.Text;
            var searchWords = text.Split(';');
            var filters = new List<IModelFilter>();
            searchWords= searchWords.Reverse().ToArray();
            foreach (var word in searchWords)
            {
                filters.Add(TextMatchFilter.Contains(this.objectListView1, word));
            }
            this.objectListView1.ModelFilter = new CompositeAllFilter(filters);

            objectListView1.Refresh();
        }

        private void objectListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectedIndex=1;

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
    }
}
