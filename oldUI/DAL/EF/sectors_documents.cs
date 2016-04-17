namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sectors_documents
    {
        public int id { get; set; }

        public int SectorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte[] Data { get; set; }

        public int? Author { get; set; }

        public bool BeingEdited { get; set; }

        public bool UsersCanEdit { get; set; }

        public bool IsPrivate { get; set; }

        [Required]
        public string Version { get; set; }

        public DateTime? DateTime { get; set; }

        public int? LastChangeUser { get; set; }

        public int? UserThatEdits { get; set; }

        public virtual performers performers { get; set; }

        public virtual performers performers1 { get; set; }

        public virtual performers performers2 { get; set; }

        public virtual sectors sectors { get; set; }
    }
}
