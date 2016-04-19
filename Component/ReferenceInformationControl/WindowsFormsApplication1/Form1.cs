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
            InitializeComponent();
            userControl11.SetUser += setUser;
        }
        public void setUser(object sender, EventArgs e)
        {
            (sender as GeneralReferenceInformation).UserId = Convert.ToInt32(numericUpDown1.Value);
        }

        private void specificReferenceInformation1_SetUser(object sender, EventArgs e)
        {
            (sender as GeneralReferenceInformation).UserId = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
