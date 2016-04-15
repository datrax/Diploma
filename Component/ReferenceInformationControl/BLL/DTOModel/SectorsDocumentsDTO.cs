﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModel
{
    public class SectorsDocumentsDTO
    {
        public int id { get; set; }

        public int SectorId { get; set; }


        public string Name { get; set; }

        public byte[] Data { get; set; }


        public string Author { get; set; }

        public bool? CanEdit { get; set; }

       // public virtual sectors sectors { get; set; }
    }
}
