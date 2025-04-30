using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSatisOtomasyonu.Core.Models
{
    public class Kiralama
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public Arac Arac { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public decimal GunlukUcret { get; set; }
        public decimal ToplamTutar => (decimal)(BitisTarihi - BaslangicTarihi).TotalDays * GunlukUcret;
    }
}