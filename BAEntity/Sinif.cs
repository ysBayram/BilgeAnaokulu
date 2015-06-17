using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    [Serializable]
    public class Sinif:BAInput,INonHuman
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Sube { get; set; }
        public virtual ICollection<Egitmen> Egitmenler { get; set; }
        public virtual ICollection<Ders> Dersler { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
        public virtual ICollection<Sinav> Sinavlar { get; set; }

        public override string ToString()
        {
            return this.Ad + " sınıfının " + this.Sube + " şubesi";
        }
    }
}
