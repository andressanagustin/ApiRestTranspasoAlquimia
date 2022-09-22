namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_correlatividad
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string codigo { get; set; }

        [StringLength(5)]
        public string cod_materia { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(5)]
        public string cod_mat_co { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }
    }
}
