using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace BLL.Contract.DTOModel
{
    public class ObjectsDTO
    {
        [OLVColumn("Id", Width = 35, TextAlign = HorizontalAlignment.Center, IsVisible = false)]
        public int id { get; set; }

        [OLVColumn("Имя объекта", Width = 100, TextAlign = HorizontalAlignment.Center)]
        public string name { get; set; }

        public override string ToString()
        {
            return String.Format("Id :{0}\n" +
                                 "Имя :{1}\n", id, name);
        }
    }
}
