namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sectors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sectors()
        {
            sectorsd_documents = new HashSet<sectorsd_documents>();
            wells = new HashSet<wells>();
        }

        public int id { get; set; }

        public int? object_id { get; set; }

        [StringLength(192)]
        public string name { get; set; }

        public virtual objects objects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sectorsd_documents> sectorsd_documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wells> wells { get; set; }
    }
}
