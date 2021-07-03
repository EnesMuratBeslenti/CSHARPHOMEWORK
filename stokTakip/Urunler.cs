using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stokTakip
{
    [Table("Urunler")]
    class Urunler
    {
        [Key]
        public int urunID { get; set; }
        public string urunKodu { get; set; }
        public string urunAdi { get; set; }
        public bool urunDurum { get; set; }
    }
}