namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesHistory")]
    public partial class SalesHistory
    {
        [Key]
        public int SaleID { get; set; }

        public int? PartnerID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SaleDate { get; set; }

        public int? Quantity { get; set; }

        public decimal? SaleAmount { get; set; }

        public virtual Partners Partners { get; set; }

        public virtual Products Products { get; set; }
    }
}
