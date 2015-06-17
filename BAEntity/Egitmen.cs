using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    [Serializable]
    public class Egitmen:BAInput,IHuman
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
        public virtual ICollection<Ders> Dersler { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
        public virtual ICollection<Sinif> Siniflar { get; set; }
        public virtual ICollection<Sinav> Sinavlar { get; set; }

        public override string ToString()
        {
            return this.Ad + " " + this.Soyad;
        }

    }
}
