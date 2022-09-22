namespace TranspasoApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userApi")]
    public partial class userApi
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string clave { get; set; }

        public int estado { get; set; }

        [StringLength(50)]
        public string token { get; set; }
    }
}
