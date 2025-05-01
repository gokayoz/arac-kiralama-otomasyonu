using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralamaSatisOtomasyonu.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AracKiralamaSatisOtomasyonu.Core.Context
{
    public class AracKiralamaSatisOtomasyonuDbContext : DbContext
    {
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<Kiralama> Kiralama { get; set; }
        public DbSet<Satis> Satis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DENIZ\\SQLEXPRESS;Database=AracKiralamaSatisOtomasyonuDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id = 1, KategoriAdi = "Sedan" },
                new Kategori { Id = 2, KategoriAdi = "SUV" },
                new Kategori { Id = 3, KategoriAdi = "Hatchback" },
                new Kategori { Id = 4, KategoriAdi = "Minivan" }
                );
        }
    }
}
