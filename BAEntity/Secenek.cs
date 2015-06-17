using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    public class Secenek:BAInput
    {
        [Required]
        public string Icerik { get; set; }
        [Required]
        public SecenekTur IcerikTur { get; set; }
        [Required]
        public string Baslik { get; set; }
        public virtual Soru Soru { get; set; }

        public override string ToString()
        {
            return this.Soru.Sinav.Ad + " sınavının " + this.Soru.No.ToString() + ". sorusunun " + this.Baslik + " seçeneği";
        }
    }
}
