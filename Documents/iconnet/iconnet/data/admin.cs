namespace iconnet.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Username { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string kode_admin { get; set; }

        [Required]
        [StringLength(50)]
        public string profile { get; set; }
    }
}
