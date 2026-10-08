namespace Morozava_210is_model4.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chek")]
    public partial class chek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idcheka { get; set; }

        public int idRabotnika { get; set; }

        public int idclienta { get; set; }

        public int summa { get; set; }

        [Required]
        [StringLength(20)]
        public string vidoplati { get; set; }

        public DateTime data { get; set; }

        public virtual client client { get; set; }

        public virtual sotrydniki sotrydniki { get; set; }
    }
}
