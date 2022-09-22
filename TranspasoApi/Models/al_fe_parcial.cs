namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_fe_parcial
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string nro_parcial { get; set; }

        [StringLength(5)]
        public string cod_materia { get; set; }

        [StringLength(5)]
        public string cod_comi { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(8)]
        public string hora { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(10)]
        public string nro_acta { get; set; }

        public short? anio { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }
    }
}
