namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lekarstva")]
    public partial class lekarstva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lekarstva()
        {
            prixodTovara = new HashSet<prixodTovara>();
            recepti = new HashSet<recepti>();
            SostavProdazi = new HashSet<SostavProdazi>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLekarstv { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string manufacturer { get; set; }

        [Column(TypeName = "money")]
        public decimal cost_price { get; set; }

        [Column(TypeName = "money")]
        public decimal selling_price { get; set; }

        public int stock { get; set; }

        [Column(TypeName = "date")]
        public DateTime expiry_date { get; set; }

        public bool prescription_required { get; set; }

        public int idPostavsika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prixodTovara> prixodTovara { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recepti> recepti { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SostavProdazi> SostavProdazi { get; set; }
    }
}
