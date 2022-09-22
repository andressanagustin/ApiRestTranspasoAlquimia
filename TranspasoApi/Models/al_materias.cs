namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_materias
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_materia { get; set; }

        [StringLength(5)]
        public string cod_carrera { get; set; }

        [StringLength(50)]
        public string nom_materia { get; set; }

        public byte? anio_cursa { get; set; }

        [StringLength(5)]
        public string cod_area { get; set; }

        public byte? can_tp { get; set; }

        public bool rc_p { get; set; }

        public bool rc_sp { get; set; }

        public bool rc_l { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(60)]
        public string rotulo { get; set; }

        public short? orden { get; set; }

        public byte? horas { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(5)]
        public string cod_plan { get; set; }
    }
}
