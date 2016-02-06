namespace SimpleAudit
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolDB : DbContext
    {
        public SchoolDB()
            : base("name=SchoolDB")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Programs> Programs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.CName)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.MinPassingGrade)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Class>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.PName)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.DName)
                .IsUnicode(false);

            modelBuilder.Entity<Degree>()
                .Property(e => e.DName)
                .IsUnicode(false);

            modelBuilder.Entity<Degree>()
                .Property(e => e.PName)
                .IsUnicode(false);

            modelBuilder.Entity<Programs>()
                .Property(e => e.PName)
                .IsUnicode(false);

            modelBuilder.Entity<Programs>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Programs>()
                .HasMany(e => e.Degrees)
                .WithRequired(e => e.Program)
                .WillCascadeOnDelete(false);
        }
    }
}
