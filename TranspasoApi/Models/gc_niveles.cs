namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gc_niveles
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_nivel { get; set; }

        [StringLength(80)]
        public string nom_nivel { get; set; }

        [StringLength(5)]
        public string cod_escue { get; set; }

        [StringLength(3)]
        public string curso { get; set; }

        [StringLength(5)]
        public string cod_siguie { get; set; }

        public double? m_cuota { get; set; }

        public double? m_matri { get; set; }

        public bool? actualiza { get; set; }

        public byte? edad_min { get; set; }

        public byte? edad_max { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(80)]
        public string titulo { get; set; }

        public byte? can_materias { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }

        public int? academico { get; set; }
    }
}
