namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_carre_comision
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_carrera { get; set; }

        [StringLength(5)]
        public string cod_comi { get; set; }

        [StringLength(2)]
        public string curso { get; set; }

        [StringLength(2)]
        public string division { get; set; }

        [StringLength(1)]
        public string turno { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(50)]
        public string detalle { get; set; }

        [StringLength(5)]
        public string cod_aula { get; set; }

        public short? anio { get; set; }
    }
}
