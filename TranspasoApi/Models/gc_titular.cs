namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gc_titular
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string cod_titu { get; set; }

        [StringLength(20)]
        public string pad_apelli { get; set; }

        [StringLength(20)]
        public string pad_nombre { get; set; }

        [StringLength(20)]
        public string mad_apelli { get; set; }

        [StringLength(20)]
        public string mad_nombre { get; set; }

        [StringLength(20)]
        public string dom_calle { get; set; }

        [StringLength(6)]
        public string dom_nro { get; set; }

        [StringLength(4)]
        public string dom_piso { get; set; }

        [StringLength(4)]
        public string dom_dpto { get; set; }

        [StringLength(1)]
        public string dom_cp1 { get; set; }

        [StringLength(4)]
        public string dom_cp2 { get; set; }

        [StringLength(3)]
        public string dom_cp3 { get; set; }

        [StringLength(20)]
        public string env_calle { get; set; }

        [StringLength(6)]
        public string env_nro { get; set; }

        [StringLength(4)]
        public string env_piso { get; set; }

        [StringLength(4)]
        public string env_dpto { get; set; }

        [StringLength(1)]
        public string env_cp1 { get; set; }

        [StringLength(4)]
        public string env_cp2 { get; set; }

        [StringLength(3)]
        public string env_cp3 { get; set; }

        [StringLength(20)]
        public string telefonos { get; set; }

        [StringLength(20)]
        public string celulares { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        [StringLength(5)]
        public string cod_grupo { get; set; }

        [StringLength(5)]
        public string cod_iva { get; set; }

        [StringLength(5)]
        public string cod_cobra { get; set; }

        [StringLength(5)]
        public string cod_zona { get; set; }

        [StringLength(5)]
        public string doc_cod { get; set; }

        [StringLength(15)]
        public string doc_nro { get; set; }

        [StringLength(5)]
        public string cod_nivel { get; set; }

        [StringLength(3)]
        public string tipo_alum { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(50)]
        public string pad_email { get; set; }

        [StringLength(50)]
        public string mad_email { get; set; }

        [StringLength(5)]
        public string pad_tipo { get; set; }

        [StringLength(5)]
        public string mad_tipo { get; set; }
    }
}
