namespace SimpleAudit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Degree")]
    public partial class Degree
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Degree()
        {
            Classes = new HashSet<Class>();
        }

        [Key]
        [StringLength(50)]
        public string DName { get; set; }

        public byte MinCoreCredits { get; set; }

        public byte MinGenCredits { get; set; }

        [Required]
        [StringLength(50)]
        public string PName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        public virtual Programs Program { get; set; }
    }
}
