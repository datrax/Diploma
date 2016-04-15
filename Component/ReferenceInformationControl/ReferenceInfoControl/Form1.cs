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
        public Form1()
        {
            InitializeComponent();              
        }

        public void LoadTab(int number)
        {
            userControl11.LoadTab(number);
        }
    }
}
