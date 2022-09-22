namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gc_adherentes
    {
        public int id { get; set; }

        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(10)]
        public string cod_titu { get; set; }

        [StringLength(2)]
        public string cod_adhe { get; set; }

        [StringLength(20)]
        public string apellido { get; set; }

        [StringLength(20)]
        public string nombre { get; set; }

        [StringLength(5)]
        public string cod_nivel { get; set; }

        [StringLength(3)]
        public string curso { get; set; }

        [StringLength(3)]
        public string division { get; set; }

        [StringLength(3)]
        public string turno { get; set; }

        [StringLength(5)]
        public string cod_doc { get; set; }

        [StringLength(15)]
        public string nro_doc { get; set; }

        public DateTime? fec_ingre { get; set; }

        public DateTime? fec_egre { get; set; }

        public DateTime? fec_naci { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        [StringLength(20)]
        public string file_foto { get; set; }

        [StringLength(3)]
        public string tipo_alum { get; set; }

        [StringLength(10)]
        public string est_civil { get; set; }

        [StringLength(3)]
        public string estado { get; set; }

        [StringLength(25)]
        public string nacionalidad { get; set; }

        [StringLength(70)]
        public string titulo { get; set; }

        [StringLength(50)]
        public string otorgado { get; set; }

        [StringLength(5)]
        public string cod_aula { get; set; }

        [StringLength(3)]
        public string cod_estado { get; set; }

        [StringLength(3)]
        public string estado1 { get; set; }

        [StringLength(10)]
        public string cod_aux { get; set; }

        [StringLength(10)]
        public string nro_socio { get; set; }

        [StringLength(10)]
        public string nro_matri { get; set; }

        [StringLength(20)]
        public string clave { get; set; }

        public bool? deuda { get; set; }

        public bool? edicion { get; set; }
    }
}
