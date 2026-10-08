namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SostavProdazi")]
    public partial class SostavProdazi
    {
        public int? prodazid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sale_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int medicine_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quantity { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal price_at_sale { get; set; }

        public int? sostavprodazid { get; set; }

        public virtual lekarstva lekarstva { get; set; }

        public virtual prodazi prodazi { get; set; }
    }
}
