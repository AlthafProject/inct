using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace iconnet.data
{
    public partial class iconnet : DbContext
    {
        public iconnet()
            : base("name=iconnet7")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<online> onlines { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.kode_admin)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.profile)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.alamat)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.kelurahan)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.kecamatan)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.kota)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.lokasi)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.layanan)
                .IsUnicode(false);

            modelBuilder.Entity<online>()
                .Property(e => e.process)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.kode_admin)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.profile)
                .IsUnicode(false);
        }
    }
}
