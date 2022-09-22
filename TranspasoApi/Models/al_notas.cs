namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_notas
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_nota { get; set; }

        public double? nota { get; set; }

        [StringLength(1)]
        public string tipo_nota { get; set; }

        [StringLength(20)]
        public string calificacion { get; set; }

        [StringLength(10)]
        public string letras { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }
    }
}
