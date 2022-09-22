namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_adhe_materias
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_materia { get; set; }

        [StringLength(10)]
        public string cod_alumno { get; set; }

        public short? anio { get; set; }

        [StringLength(5)]
        public string cod_comi { get; set; }

        [StringLength(2)]
        public string t_cursado { get; set; }

        [StringLength(2)]
        public string t_cursado2 { get; set; }

        [StringLength(2)]
        public string t_cursado3 { get; set; }

        public DateTime? fecha_ins { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }
    }
}
