using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSatisOtomasyonu.Core.Models
{
    public class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int Kilometre { get; set; }
        public string YakitTuru { get; set; }
        public string SanzimanTipi { get; set; }
        public string Renk { get; set; }
        public string Durum { get; set; } 
        public string MevcutDurum { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public List<Kiralama> Kiralamalar { get; set; }
        public List<Satis> Satislar { get; set; }
    }
}