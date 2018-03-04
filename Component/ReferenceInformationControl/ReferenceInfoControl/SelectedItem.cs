using BLL.Contract.DTOModel;
using ReferenceInfoControl.ServiceReference;

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
        public static string GetItemAsString(object rowObject)
        {

            if (rowObject is WellsDTO)
                return (rowObject as WellsDTO).ToString();

            if (rowObject is SectorsDTO)
                return (rowObject as SectorsDTO).ToString();

            if (rowObject is ObjectsDTO)
                return (rowObject as ObjectsDTO).ToString();
            if (rowObject is DocumentsDTO)
                return (rowObject as DocumentsDTO).dateTime.ToString();
            return "";
        }
    }
}
