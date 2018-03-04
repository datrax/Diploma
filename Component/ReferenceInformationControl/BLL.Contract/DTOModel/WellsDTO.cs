using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace BLL.Contract.DTOModel
{
    public class WellsDTO
    {
        [OLVColumn("Id скважины", TextAlign = HorizontalAlignment.Center)]
        public int id { get; set; }
        [OLVColumn("Имя скважины", TextAlign = HorizontalAlignment.Center)]
        public string char_name { get; set; }
        [OLVColumn("Id сектора", TextAlign = HorizontalAlignment.Center,IsVisible = false)]
        public int? sector_id { get; set; }
        [OLVColumn("Имя сектора", TextAlign = HorizontalAlignment.Center)]
        public string sector_name { get; set; }
        [OLVColumn("Х", TextAlign = HorizontalAlignment.Center)]
        public double? coordX { get; set; }
        [OLVColumn("У", TextAlign = HorizontalAlignment.Center)]
        public double? coordY { get; set; }
        [OLVColumn("Инд. Выс.", TextAlign = HorizontalAlignment.Center)]
        public double? index_altitude { get; set; }
        [OLVColumn("Ур. Выс.", TextAlign = HorizontalAlignment.Center)]
        public double? level_altitude { get; set; }
        [OLVColumn("Глуб.", TextAlign = HorizontalAlignment.Center)]
        public double? depth { get; set; }
        [OLVColumn("Гориз.", TextAlign = HorizontalAlignment.Center)]
        public int? horizon { get; set; }
        [OLVColumn("Фильтр врх.", TextAlign = HorizontalAlignment.Center)]
        public double? filter_up { get; set; }
        [OLVColumn("Фильтр нз.", TextAlign = HorizontalAlignment.Center)]
        public double? filter_down { get; set; }
        [OLVColumn("Заметка", TextAlign = HorizontalAlignment.Center)]
        public string note { get; set; }
        [OLVColumn("Дата", TextAlign = HorizontalAlignment.Center)]
        public DateTime? date { get; set; }

        public override string ToString()
        {
            return String.Format("Id :{0}\n" +
                                 "Имя :{1}\n" +
                                  "Заметка:{2}\n" +
                                 "Сектор:{3}\n" +
                                 "Х:{4}\n" +
                                   "У:{5}\n" +
                                 "Инд. Выс.:{6}\n" +
                                 "Ур. Выс.:{7}\n" +
                                 "Глуб.:{8}\n" +
                                 "Гориз.{9}\n" +
                                  "Фильтр врх.:{10}\n" +
                                   "Фильтр нз.:{11}\n" +
                                    "Дата.:{12}\n", id, char_name, note, sector_name, coordX, coordY, index_altitude, level_altitude, depth, horizon, filter_up, filter_down, date);
        }
    }
}
