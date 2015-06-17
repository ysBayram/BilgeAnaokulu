using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    [Serializable]
    public class Ogrenci : BAInput, IHuman
    {
        [Required]
        public string TCKimlikNo { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public KanGrubulari KanGrubu { get; set; }
        [Required]
        public string VeliAd { get; set; }
        [Required]
        public string VeliCepTel { get; set; }
        public string VeliTel { get; set; }
        [Required]
        public DateTime KayitTarihi { get; set; }
        [Required]
        public string Donem { get; private set; }
        public virtual Egitmen Egitmeni { get; set; }
        public virtual Sinif Sinifi { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }
        public virtual ICollection<Sinav> Sinavlar { get; set; }

        public Ogrenci()
        {
            this.Donem = DateTime.Now.Year.ToString() + " - " + DateTime.Now.AddYears(1).Year.ToString();
        }

        public override string ToString()
        {
            return this.Ad + " " + this.Soyad;
        }
    }
}
