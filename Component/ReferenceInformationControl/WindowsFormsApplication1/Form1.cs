using System;
using System.Drawing;
using System.Windows.Forms;

using ObjectsReferenceInformationControl;
using ReferenceInfoControl;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.SetUser += setUser;
        }
        public void setUser(object sender, EventArgs e)
        {
            (sender as GeneralReferenceInformation).UserId = Convert.ToInt32(numericUpDown1.Value);
        }

    }
}
