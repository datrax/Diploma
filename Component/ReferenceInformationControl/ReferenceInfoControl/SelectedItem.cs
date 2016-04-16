using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOModel;

namespace ReferenceInfoControl
{
    public class SelectedItem
    {
        public int Id { get; set; }
        public object item { get; set; }

        public void SetItem(object item)
        {
            this.item = item;
            if (item is WellsDTO)
            {
                var i=item as WellsDTO;
                Id = i.id;
            }
            if (item is SectorsDTO)
            {
                var i = item as SectorsDTO;
                Id = i.id;
            }

            if (item is ObjectsDTO)
            {
                var i = item as ObjectsDTO;
                Id = i.id;
            }
        }
    }
}
