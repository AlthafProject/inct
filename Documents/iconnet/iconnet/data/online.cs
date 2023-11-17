namespace iconnet.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("online")]
    public partial class online
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int Nik { get; set; }

        public int Nohp { get; set; }

        public int kdmeteran { get; set; }

        [Required]
        [StringLength(200)]
        public string alamat { get; set; }

        [Required]
        [StringLength(50)]
        public string kelurahan { get; set; }

        [Required]
        [StringLength(50)]
        public string kecamatan { get; set; }

        [Required]
        [StringLength(50)]
        public string kota { get; set; }

        [Required]
        [StringLength(200)]
        public string lokasi { get; set; }

        [Required]
        [StringLength(50)]
        public string layanan { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        [StringLength(50)]
        public string process { get; set; }
    }
}
