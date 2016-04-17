using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DAL;
using DAL.EF;
using ReferenceInfoControl;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private IUnitOfWork unitOfWork;
        public Form1()
        {
            unitOfWork = new UnitOfWork<ModelContext>();
            InitializeComponent();
       //     Generator.GenerateColumns(this.objectListView1, typeof(objects), true);
            unitOfWork.GetRepository<objects>().GetAll().ToList();
            userControl11.SetUser+= delegate(object sender, EventArgs args)
            {
               (sender as UserControl1).UserId= Convert.ToInt32(numericUpDown1.Value);
            };
        }

        public void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

   
        }
    }
}
