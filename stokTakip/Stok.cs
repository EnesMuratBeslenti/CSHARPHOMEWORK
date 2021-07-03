using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stokTakip
{
    [Table("Stok")]
    class Stok
    {
        [Key]
        public int stokID { get; set; }
        public string UrunKodu { get; set; }
        [MaxLength(128)]
        public string urunAdi { get; set; }
        public DateTime tarih { get; set; }
        public double adet { get; set; }
        public bool urunDurum { get; set; }
    }
}