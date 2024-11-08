using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MasterPol
{
    public partial class MasterPolModel : DbContext
    {
        public MasterPolModel()
            : base("name=MasterPol")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SalesHistory> SalesHistory { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.PassportDetails)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.BankDetails)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.HealthStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.MaterialType)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.MaterialName)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.UnitOfMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Materials>()
                .Property(e => e.ChangeHistory)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.PartnerType)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.LegalAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.DirectorName)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Partners>()
                .Property(e => e.SalesHistory)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ArticleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.MinPriceForPartner)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.PackageSize)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.WeightWithoutPackaging)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.WeightWithPackaging)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.QualityCertificate)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.StandardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.PriceChangeHistory)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.CostPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SalesHistory>()
                .Property(e => e.SaleAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.SupplierType)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Suppliers>()
                .Property(e => e.SupplyHistory)
                .IsUnicode(false);
        }
    }
}
