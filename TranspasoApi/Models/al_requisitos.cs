namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class al_requisitos
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(5)]
        public string cod_requi { get; set; }

        [StringLength(30)]
        public string nom_requi { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(5)]
        public string rotulo { get; set; }

        public byte? fi_ctrreq { get; set; }
    }
}
