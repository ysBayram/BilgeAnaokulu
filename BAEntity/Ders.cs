using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    [Serializable]
    public class Ders:BAInput,INonHuman
    {
        [Required]
        public string Ad { get; set; }
        public string Icerik { get; set; }
        public DateTime BaslamaZaman { get; set; }
        public DateTime BitisZaman { get; set; }
        public virtual Sinif Sinifi { get; set; }
        public virtual Egitmen Egitmeni { get; set; }
        public virtual ICollection< Ogrenci> Ogrenciler { get; set; }
        public virtual ICollection<Sinav> Sinavlar { get; set; }

        public override string ToString()
        {
            return this.Ad;
        }

    }
}
