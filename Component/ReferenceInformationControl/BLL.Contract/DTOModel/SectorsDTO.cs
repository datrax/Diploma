using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace BLL.Contract.DTOModel
{
   public class SectorsDTO
    {
        [OLVColumn("Id", Width = 35, TextAlign = HorizontalAlignment.Center, IsVisible = false, DisplayIndex = 0)]
        public int id { get; set; }
        [OLVColumn("Объкт", Width = 100, TextAlign = HorizontalAlignment.Center, IsVisible = true,DisplayIndex = 2)]
        public string objectName { get; set; }
        [OLVColumn("Id Объкта", Width = 100, TextAlign = HorizontalAlignment.Center, IsVisible = false, DisplayIndex = 3)]
        public int? object_id { get; set; }
        [OLVColumn("Участок", Width = 100, TextAlign = HorizontalAlignment.Center, IsVisible = true,DisplayIndex = 1)]
        public string name { get; set; }
        public override string ToString()
        {
            return String.Format("Id :{0}\n" +
                                 "Имя :{1}\n"+
                                 "Объект :{2}\n" ,
                                  id, name,objectName);
        }
    }
}
