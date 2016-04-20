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
            for (int i = 0; i < 4; i++)
            {
                var p = new SpecificReferenceInformation(1, i+1, "Объект " + (i+1));
                p.Width = 200;
                p.Location=new Point(15,i*30+5);
                p.SetUser += setUser;
                this.Controls.Add(p);
            }
           
        }
        public void setUser(object sender, EventArgs e)
        {
            (sender as GeneralReferenceInformation).UserId = Convert.ToInt32(numericUpDown1.Value);
        }


    }
}
