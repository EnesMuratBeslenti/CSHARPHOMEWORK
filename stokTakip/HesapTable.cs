using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace stokTakip
{
    [Table("Hesap")]
    class HesapTable
    {
        [Key]
        public int id { get; set; }
        [MaxLength(64)]
        public string k_adi { get; set; }
        [MaxLength(128)]
        public string sifre { get; set; }
    }
}
