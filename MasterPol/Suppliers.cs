namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Suppliers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suppliers()
        {
            Materials = new HashSet<Materials>();
        }

        [Key]
        public int SupplierID { get; set; }

        [StringLength(50)]
        public string SupplierType { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(12)]
        public string INN { get; set; }

        [Column(TypeName = "text")]
        public string SupplyHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materials> Materials { get; set; }
    }
}
