namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_nota_parcial
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string cod_alumno { get; set; }

        [StringLength(10)]
        public string nro_parcial { get; set; }

        [StringLength(1)]
        public string asistencia { get; set; }

        public double? nota { get; set; }

        public double? nota_old { get; set; }

        [StringLength(1)]
        public string tipo_nota { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }
    }
}
