using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    public class Yoklama:BAInput
    {
        [Required]
        public DateTime Tarih { get; set; }
        [Required]
        public bool DevamDurumu { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }

        public override string ToString()
        {
            string devam = string.Empty;
            if(DevamDurumu){devam = "Devamlı";}else{devam = "Devamsız";};
            return this.Ogrenci.Ad + " " + this.Ogrenci.Soyad + " isimli öğrencinin " + this.Tarih.ToShortDateString() + " tarihli yoklaması " + devam;
        }
    }
}
