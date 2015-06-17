using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    public class Sinav:BAInput,INonHuman
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public int Puan { get; set; }
        [Required]
        public int Sure { get; set; }
        [Required]
        public DateTime BaslangicZaman { get; set; }
        [Required]
        public DateTime BitisZaman { get; set; }
        public virtual Egitmen Egitmen { get; set; }
        public virtual Ders Ders { get; set; }
        public virtual Sinif Sinif { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }

        public virtual ICollection<Soru> Sorular { get; set; }

        public override string ToString()
        {
            return this.Ad;
        }

    }
}
