namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(100)]
        public string PassportDetails { get; set; }

        [StringLength(100)]
        public string BankDetails { get; set; }

        public bool? HasFamily { get; set; }

        [StringLength(100)]
        public string HealthStatus { get; set; }
    }
}
