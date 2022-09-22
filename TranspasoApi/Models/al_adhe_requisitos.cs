namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_adhe_requisitos
    {
        public int id { get; set; }

        [Required]
        [StringLength(5)]
        public string cod_empre { get; set; }

        [Required]
        [StringLength(10)]
        public string cod_titu { get; set; }

        [Required]
        [StringLength(3)]
        public string cod_estado { get; set; }

        [Required]
        [StringLength(5)]
        public string cod_requi { get; set; }

        public DateTime fecha { get; set; }

        public byte? fi_ctrreq { get; set; }
    }
}
