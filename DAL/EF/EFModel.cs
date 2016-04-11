using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace DAL.EF
{


    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<objects> objects { get; set; }
        public virtual DbSet<sectors> sectors { get; set; }
        public virtual DbSet<wells> wells { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<objects>()
                .HasMany(e => e.sectors)
                .WithOptional(e => e.objects)
                .HasForeignKey(e => e.object_id);

            modelBuilder.Entity<sectors>()
                .HasMany(e => e.wells)
                .WithOptional(e => e.sectors)
                .HasForeignKey(e => e.sector_id);
        }
    }
}
