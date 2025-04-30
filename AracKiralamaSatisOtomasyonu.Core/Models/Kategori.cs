using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSatisOtomasyonu.Core.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<Arac> Araclar { get; set; }
    }
}