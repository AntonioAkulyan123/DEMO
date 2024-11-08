namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            SalesHistory = new HashSet<SalesHistory>();
        }

        [Key]
        public int ProductID { get; set; }

        [StringLength(20)]
        public string ArticleNumber { get; set; }

        [StringLength(50)]
        public string ProductType { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public decimal? MinPriceForPartner { get; set; }

        public decimal? PackageSize { get; set; }

        public decimal? WeightWithoutPackaging { get; set; }

        public decimal? WeightWithPackaging { get; set; }

        [StringLength(255)]
        public string QualityCertificate { get; set; }

        [StringLength(50)]
        public string StandardNumber { get; set; }

        [Column(TypeName = "text")]
        public string PriceChangeHistory { get; set; }

        public int? ProductionTime { get; set; }

        public decimal? CostPrice { get; set; }

        public int? WorkshopNumber { get; set; }

        public int? WorkersCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesHistory> SalesHistory { get; set; }
    }
}
