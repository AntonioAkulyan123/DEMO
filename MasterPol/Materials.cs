namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materials
    {
        [Key]
        public int MaterialID { get; set; }

        [StringLength(50)]
        public string MaterialType { get; set; }

        [StringLength(100)]
        public string MaterialName { get; set; }

        public int? SupplierID { get; set; }

        public int? QuantityPerPack { get; set; }

        [StringLength(50)]
        public string UnitOfMeasure { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public decimal? Price { get; set; }

        public int? StockQuantity { get; set; }

        public int? MinAcceptableQuantity { get; set; }

        [Column(TypeName = "text")]
        public string ChangeHistory { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
