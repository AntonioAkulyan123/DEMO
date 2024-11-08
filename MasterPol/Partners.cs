namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            SalesHistory1 = new HashSet<SalesHistory>();
        }

        [Key]
        public int PartnerID { get; set; }

        [StringLength(50)]
        public string PartnerType { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string LegalAddress { get; set; }

        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(100)]
        public string DirectorName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Logo { get; set; }

        public int? Rating { get; set; }

        [Column(TypeName = "text")]
        public string SalesHistory { get; set; }

        [NotMapped] // Этого свойства не будет в базе данных
        public double SalesAmount
        {
            get
            {
                // Суммируем SaleAmount для всех продаж, связанных с партнером и приводим к типу double
                return (double)(SalesHistory1?.Sum(sh => sh.SaleAmount ?? 0) ?? 0);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesHistory> SalesHistory1 { get; set; }

        // Используем DiscountCalculator для вычисления скидки
        public double DiscountPercentage => DiscountCalculator.CalculateDiscount(SalesAmount);
    }
}