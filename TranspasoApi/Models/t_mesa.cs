namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_mesa
    {
        public int id { get; set; }

        [Required]
        [StringLength(2)]
        public string cod_tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string nom_tipo { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }
    }
}
