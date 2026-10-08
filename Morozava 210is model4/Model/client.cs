namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("client")]
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            chek = new HashSet<chek>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClienta { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string secondname { get; set; }

        [Required]
        [StringLength(30)]
        public string sername { get; set; }

        [Required]
        [StringLength(30)]
        public string telephone { get; set; }

        [Required]
        [StringLength(30)]
        public string bill { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chek> chek { get; set; }
    }
}
