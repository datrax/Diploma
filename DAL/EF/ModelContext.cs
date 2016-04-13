namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<objects> objects { get; set; }
        public virtual DbSet<sectors> sectors { get; set; }
        public virtual DbSet<sectorsd_documents> sectorsd_documents { get; set; }
        public virtual DbSet<wells> wells { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<objects>()
                .HasMany(e => e.sectors)
                .WithOptional(e => e.objects)
                .HasForeignKey(e => e.object_id);

            modelBuilder.Entity<sectors>()
                .HasMany(e => e.sectorsd_documents)
                .WithRequired(e => e.sectors)
                .HasForeignKey(e => e.SectorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sectors>()
                .HasMany(e => e.wells)
                .WithOptional(e => e.sectors)
                .HasForeignKey(e => e.sector_id);
        }
    }
}
