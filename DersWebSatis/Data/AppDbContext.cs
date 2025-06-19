using DersWebSatis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersWebSatis.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<UrunKategori> Kategoris { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Siparis> Sipsaris { get; set; }
        public DbSet<SiparisItem> SiparisItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Server=localhost;
                Database=AlisVeris;
                Trusted_Connection=True;
                TrustServerCertificate=True;"
             );
        }
    }
}
