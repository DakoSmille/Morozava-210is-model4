namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("recepti")]
    public partial class recepti
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idRezepta { get; set; }

        [StringLength(50)]
        public string patient_name { get; set; }

        [StringLength(50)]
        public string doctor_name { get; set; }

        public int? medicine_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? prescription_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expiry_date { get; set; }

        public virtual lekarstva lekarstva { get; set; }
    }
}
