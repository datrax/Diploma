namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sectorsd_documents
    {
        public int id { get; set; }

        public int SectorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte[] Data { get; set; }

        [StringLength(150)]
        public string Author { get; set; }

        public bool? CanEdit { get; set; }

        public virtual sectors sectors { get; set; }
    }
}
