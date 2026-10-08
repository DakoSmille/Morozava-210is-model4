namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prixodTovara")]
    public partial class prixodTovara
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPrixoda { get; set; }

        public int medicine_id { get; set; }

        public int supplier_id { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime arrival_date { get; set; }

        public int employee_id { get; set; }

        public virtual lekarstva lekarstva { get; set; }

        public virtual postavsiki postavsiki { get; set; }

        public virtual sotrydniki sotrydniki { get; set; }
    }
}
