using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceInfoControl;

namespace ObjectsReferenceInformationControl
{
    public partial class SpecificReferenceInformation : UserControl
    {
        private string myText;
        private int _typeNumber;
        private int? id;
        [Category("Gradient"), Description("Початковий колір заповнення"), DefaultValue("Объекты")]
        public int? Id
        {
            get
            {
                return id;               
            }
            set { id = value; }
        }

        [Category("Gradient"), Description("Початковий колір заповнення"), DefaultValue("Объекты")]
        public string MyText
        {
            get { return myText; }
            set
            {
                myText = value;
                button1.Text = myText;
                Invalidate();
            }
        }

        public enum Types : int { Объекты=0,Участки = 1, Скважины = 2, }

        [Category("Gradient"), Description("Початковий колір заповнення"), DefaultValue(Types.Объекты)]
        public Types Type
        {
            get { return type; }
            set
            {
                type = value;

                if (value == Types.Объекты)
                    _typeNumber = 1;
                if (value == Types.Участки)
                    _typeNumber = 2;
                if (value == Types.Скважины)
                    _typeNumber = 3;
                Invalidate();
            }
        }
        private Types type;

         EventHandler setUser;
        [Category("Search"), Description("Called when the first input of specific word found")]
        public event EventHandler SetUser
        {
            add { setUser += value; }
            remove { setUser -= value; }
        }
        public SpecificReferenceInformation()
        {
            if (DesignMode)
                return;
            InitializeComponent();
            button1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("rsz_dokumenti");
            button1.BackgroundImageLayout = ImageLayout.Stretch;

        }

        /// <summary>
        /// Use 1 for Объекты, 2 for Участки, 3 for Скважины
        /// </summary>
        /// <param name="_typeNumber"></param>
        public SpecificReferenceInformation(int _typeNumber,string text):this()
        {
            if (_typeNumber == 1)
                type = Types.Объекты;
            if (_typeNumber == 2)
                type = Types.Участки;
            if (_typeNumber == 3)
                type = Types.Скважины;            
            MyText = text;
        }
        public SpecificReferenceInformation(int _typeNumber, int id,string text) : this(_typeNumber,text)
        {
            this._typeNumber = _typeNumber;
            this.id = id;
            MyText = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            var form = new Form1 { SetUser = setUser };

            form.Show(); 
            var tab = 1;
            if (Type == Types.Участки)
                tab = 2;
            if (Type == Types.Скважины)
                tab = 3;
            form.LoadTab(tab);
            if (id != null)
            {
                form.LoadDoc(_typeNumber,id.Value);
            }
        }
    }
}
