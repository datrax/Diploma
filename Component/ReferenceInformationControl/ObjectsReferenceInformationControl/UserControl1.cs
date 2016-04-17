using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceInfoControl;

namespace ObjectsReferenceInformationControl
{
    public partial class UserControl1: UserControl
    {
        public EventHandler SetUser;
        public UserControl1()
        {
            if (DesignMode)
                return;
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            var form=new ReferenceInfoControl.Form1();
            form.SetUser = SetUser;
            form.Show();
            form.LoadTab(2);

        }
    }
}
