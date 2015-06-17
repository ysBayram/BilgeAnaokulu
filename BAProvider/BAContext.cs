using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BAEntity;

namespace BAProvider
{
    public class BAContext : DbContext,IDisposable
    {
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Egitmen> Egitmen { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<Sinav> Sinav { get; set; }
        public DbSet<Soru> Soru { get; set; }
        public DbSet<Secenek> Secenek { get; set; }
        public DbSet<Yoklama> Yoklama { get; set; }

        public BAContext()
        {
            Database.SetInitializer(new DBInitializer());
        }
    }
}
