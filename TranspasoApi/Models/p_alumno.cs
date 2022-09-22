namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p_alumno
    {
        public int id { get; set; }

        [Required]
        [StringLength(5)]
        public string cod_empre { get; set; }

        [StringLength(4)]
        public string cp_codigo { get; set; }

        [StringLength(5)]
        public string cod_doc { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        [StringLength(5)]
        public string cod_zona { get; set; }

        [StringLength(5)]
        public string cod_grupo { get; set; }

        [StringLength(3)]
        public string cod_iva { get; set; }

        [StringLength(5)]
        public string cod_perso { get; set; }

        [StringLength(10)]
        public string nro_actap { get; set; }

        [StringLength(10)]
        public string nro_actaf { get; set; }

        public short? c_especial { get; set; }

        public bool? ctrol_c { get; set; }

        public short? dias_c { get; set; }

        public bool? ctrol_df { get; set; }

        public bool? ctrol_dp { get; set; }

        public short? c_dia_exa { get; set; }

        public short? cuo_d { get; set; }

        public short? cuo_f { get; set; }

        public short? pa_ctrde { get; set; }

        public DateTime? pa_fec { get; set; }

        public short? pa_cuo { get; set; }

        public short? fi_espe { get; set; }

        public short? fi_ctrde { get; set; }

        public DateTime? fi_fec { get; set; }

        public short? fi_cuo { get; set; }

        public short? fi_ctrci { get; set; }

        public short? fi_dias { get; set; }

        public short? fi_ctrre { get; set; }

        public short? fi_ctrco { get; set; }

        public short? pa_ctrap { get; set; }

        [StringLength(2)]
        public string pa_mes { get; set; }

        [StringLength(4)]
        public string pa_anio { get; set; }

        [StringLength(2)]
        public string fi_mes { get; set; }

        [StringLength(4)]
        public string fi_anio { get; set; }

        public short? fi_ctrreq { get; set; }

        public short? fi_ctrasi { get; set; }

        public double? fi_porasi { get; set; }
    }
}
