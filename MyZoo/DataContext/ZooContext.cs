namespace MyZoo.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZooContext : DbContext
    {
        public ZooContext()
            : base("name=ZooContext")
        {
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Enviorment> Enviorment { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<MedicineDiagnosisRelation> MedicineDiagnosisRelation { get; set; }
        public virtual DbSet<Relations> Relations { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Veterinary> Veterinary { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(e => e.AnimalWeight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Animal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Relations)
                .WithOptional(e => e.Animal)
                .HasForeignKey(e => e.ChildId);

            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Relations1)
                .WithOptional(e => e.Animal1)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Diagnosis)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Diagnosis>()
                .Property(e => e.Journal)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnosis>()
                .HasMany(e => e.MedicineDiagnosisRelation)
                .WithRequired(e => e.Diagnosis)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Enviorment>()
                .Property(e => e.EName)
                .IsUnicode(false);

            modelBuilder.Entity<Enviorment>()
                .HasMany(e => e.Species)
                .WithRequired(e => e.Enviorment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodType>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<FoodType>()
                .HasMany(e => e.Species)
                .WithRequired(e => e.FoodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicine>()
                .Property(e => e.MedicineName)
                .IsUnicode(false);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.MedicineDiagnosisRelation)
                .WithRequired(e => e.Medicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Species>()
                .Property(e => e.SName)
                .IsUnicode(false);

            modelBuilder.Entity<Species>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Species>()
                .HasMany(e => e.Animal)
                .WithRequired(e => e.Species)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Veterinary>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Veterinary>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Veterinary)
                .WillCascadeOnDelete(false);
        }
    }
}
