using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceInfoControl
{
    public partial class Form1 : Form
    {
        public EventHandler SetUser;
        public Form1()
        {
            InitializeComponent();
     
        }
        public void LoadDoc(int mode,int id)
        {
            this.userControl11.SetUser = SetUser;
            userControl11.LoadDocs(mode,id);

        }
        public void LoadTab(int number)
        {
            this.userControl11.SetUser = SetUser;
            userControl11.LoadTab(number);

        }
    }
}
