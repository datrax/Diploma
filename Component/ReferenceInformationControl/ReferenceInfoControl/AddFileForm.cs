using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ReferenceInfoControl
{
    public partial class AddFileForm : Form
    {
        public AddFileForm()
        {
            InitializeComponent();
        }

        private SelectedItem selectedItem;
        private Services services;
        private int userId;
        private UserControl1 _userControl1;
        private bool isPrivate = false;
        private bool canBeEdited = true;
        public AddFileForm(UserControl1 userControl1)
        {
            selectedItem = userControl1.selectedItem;
            this.userId = userControl1.UserId;
            this.services = userControl1.services;
            this._userControl1 = userControl1;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var bytes = File.ReadAllBytes(textBox1.Text);
            services.AddFile(textBox2.Text, userId, textBox3.Text, bytes, selectedItem.Id, isPrivate,canBeEdited,selectedItem.item.GetType());
            _userControl1.LoadDocuments();
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = selectFileDialog.FileName;
                    textBox2.Text = selectFileDialog.SafeFileName;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                isPrivate = false;
                canBeEdited = true;
            }else
            if (radioButton2.Checked)
            {
                isPrivate = false;
                canBeEdited = false;
            }
            else
            if (radioButton3.Checked)
            {
                isPrivate = true;
                canBeEdited = true;
            }
        }
    }
}
