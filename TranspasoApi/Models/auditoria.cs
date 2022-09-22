namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("auditoria")]
    public partial class auditoria
    {
        public int id { get; set; }

        public DateTime fecha { get; set; }

        public bool resultado { get; set; }

        [Required]
        [StringLength(255)]
        public string resultadoDetalle { get; set; }
    }
}
