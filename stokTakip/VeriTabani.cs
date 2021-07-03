using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace stokTakip
{
    class VeriTabani : DbContext
    {
        public VeriTabani() : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<VeriTabani>());
        }
        public DbSet<Stok> StokTablosu { get; set; }
        public DbSet<Urunler> UrunlerTablosu { get; set; }
        public DbSet<HesapTable> HesapTablosu { get; set; }
    }
}