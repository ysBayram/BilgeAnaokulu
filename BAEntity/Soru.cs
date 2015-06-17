using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    public class Soru:BAInput
    {
        [Required]
        public int No { get; set; }
        [Required]
        public string Icerik { get; set; }
        [Required]
        public int PuanDeger { get; set; }
        public virtual Sinav Sinav { get; set; }
        public virtual Secenek DogruSecenek { get; set; }
        /// <summary>
        /// Doğru Seçenek komple sorudan ayrılacak onun yerien secenekte dogruluk kontrol edilecek
        /// </summary>
        public virtual ICollection<Secenek> Secenekler { get; set; }

        public override string ToString()
        {
            return this.Sinav.Ad + " sınavının " + this.No + ". sorusu";
        }
    }
}
