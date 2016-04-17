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
        public virtual DbSet<objects_documents> objects_documents { get; set; }
        public virtual DbSet<performers> performers { get; set; }
        public virtual DbSet<performers_roles> performers_roles { get; set; }
        public virtual DbSet<sectors> sectors { get; set; }
        public virtual DbSet<sectors_documents> sectors_documents { get; set; }
        public virtual DbSet<wells> wells { get; set; }
        public virtual DbSet<wells_documents> wells_documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<objects>()
                .HasMany(e => e.objects_documents)
                .WithRequired(e => e.objects)
                .HasForeignKey(e => e.ObjectId);

            modelBuilder.Entity<objects>()
                .HasMany(e => e.sectors)
                .WithOptional(e => e.objects)
                .HasForeignKey(e => e.object_id);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.objects_documents)
                .WithOptional(e => e.performers)
                .HasForeignKey(e => e.Author);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.objects_documents1)
                .WithOptional(e => e.performers1)
                .HasForeignKey(e => e.LastChangeUser);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.performers_roles)
                .WithRequired(e => e.performers)
                .HasForeignKey(e => e.performer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.sectors_documents)
                .WithOptional(e => e.performers)
                .HasForeignKey(e => e.Author);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.sectors_documents1)
                .WithOptional(e => e.performers1)
                .HasForeignKey(e => e.LastChangeUser);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.wells_documents)
                .WithOptional(e => e.performers)
                .HasForeignKey(e => e.Author);

            modelBuilder.Entity<performers>()
                .HasMany(e => e.wells_documents1)
                .WithOptional(e => e.performers1)
                .HasForeignKey(e => e.LastChangeUser);

            modelBuilder.Entity<sectors>()
                .HasMany(e => e.sectors_documents)
                .WithRequired(e => e.sectors)
                .HasForeignKey(e => e.SectorId);

            modelBuilder.Entity<sectors>()
                .HasMany(e => e.wells)
                .WithOptional(e => e.sectors)
                .HasForeignKey(e => e.sector_id);

            modelBuilder.Entity<wells>()
                .HasMany(e => e.wells_documents)
                .WithRequired(e => e.wells)
                .HasForeignKey(e => e.WellId);
        }
    }
}
