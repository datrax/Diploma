namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wells
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wells()
        {
            wells_documents = new HashSet<wells_documents>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(48)]
        public string char_name { get; set; }

        public int? sector_id { get; set; }

        public double? coordX { get; set; }

        public double? coordY { get; set; }

        public double? index_altitude { get; set; }

        public double? level_altitude { get; set; }

        public double? depth { get; set; }

        public int? horizon { get; set; }

        public double? filter_up { get; set; }

        public double? filter_down { get; set; }

        public string note { get; set; }

        public DateTime? date { get; set; }

        public virtual sectors sectors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wells_documents> wells_documents { get; set; }
    }
}
