namespace SimpleAudit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [Key]
        [StringLength(50)]
        public string CName { get; set; }

        public decimal MinPassingGrade { get; set; }

        public byte Credits { get; set; }

        [Required]
        [StringLength(50)]
        public string Teacher { get; set; }

        [StringLength(50)]
        public string PName { get; set; }

        [StringLength(50)]
        public string DName { get; set; }

        public virtual Degree Degree { get; set; }

        public virtual Programs Program { get; set; }
    }
}
