namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_adhe_carreras
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string cod_alumno { get; set; }

        [StringLength(5)]
        public string cod_carrera { get; set; }

        [StringLength(5)]
        public string cod_comi { get; set; }

        [StringLength(4)]
        public string anio { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }
    }
}
