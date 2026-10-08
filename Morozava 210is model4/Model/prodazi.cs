namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prodazi")]
    public partial class prodazi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prodazi()
        {
            SostavProdazi = new HashSet<SostavProdazi>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProdazi { get; set; }

        [Column(TypeName = "date")]
        public DateTime sale_datetime { get; set; }

        public int cashier_id { get; set; }

        public int total_amount { get; set; }

        public virtual sotrydniki sotrydniki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SostavProdazi> SostavProdazi { get; set; }
    }
}
