using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using DAL;
using DAL.EF;

namespace ReferecneInformationControl
{
    public partial class UserControl1: UserControl
    {
        private IUnitOfWork unitOfWork;
        public UserControl1()
        {
            unitOfWork=new UnitOfWork<ModelContext>();
            InitializeComponent();
            Generator.GenerateColumns(this.objectListView1, typeof(object), true);
            objectListView1.SetObjects(unitOfWork.GetRepository<objects>().GetAll().ToList());
        }
    }
}
