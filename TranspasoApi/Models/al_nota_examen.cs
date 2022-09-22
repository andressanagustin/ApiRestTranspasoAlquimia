namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_nota_examen
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string cod_alumno { get; set; }

        [StringLength(10)]
        public string nro_mesa { get; set; }

        [StringLength(10)]
        public string nro_folio { get; set; }

        [StringLength(10)]
        public string nro_examen { get; set; }

        [StringLength(1)]
        public string asistencia { get; set; }

        public double? nota { get; set; }

        public double? nota_old { get; set; }

        [StringLength(1)]
        public string tipo_nota { get; set; }

        [StringLength(30)]
        public string detalle { get; set; }

        public bool? provisorio { get; set; }

        public bool? deuda { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        public bool? nuevo { get; set; }
        public bool? elimina { get; set; }
    }
}
