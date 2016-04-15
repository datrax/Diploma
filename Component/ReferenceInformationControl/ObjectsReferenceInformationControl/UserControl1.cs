using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceInfoControl;

namespace ObjectsReferenceInformationControl
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form=new ReferenceInfoControl.Form1();
            form.Show();
            form.LoadTab(1);

        }
    }
}
