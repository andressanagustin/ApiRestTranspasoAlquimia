namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_fe_examen
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string nro_examen { get; set; }

        [StringLength(5)]
        public string cod_materia { get; set; }

        public DateTime? fecha { get; set; }

        public double? hora { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(5)]
        public string cod_profe { get; set; }

        [StringLength(5)]
        public string cod_vocal1 { get; set; }

        [StringLength(5)]
        public string cod_vocal2 { get; set; }

        [StringLength(2)]
        public string modalidad { get; set; }

        [StringLength(10)]
        public string nro_acta { get; set; }

        [StringLength(10)]
        public string nro_libro { get; set; }

        [StringLength(10)]
        public string nro_folio { get; set; }

        [StringLength(2)]
        public string mesa { get; set; }

        public byte? llamado { get; set; }

        public short? anio { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }
    }
}
