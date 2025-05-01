using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSatisOtomasyonu.Core.Models
{
    public class Satis
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public Arac Arac { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal SatisFiyati { get; set; }
        public string OdemeTipi { get; set; }
    }
}