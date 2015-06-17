using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    interface IHuman
    {
        [Required]
        string TCKimlikNo { get; set; }
        [Required]
        string Sifre { get; set; }
        [Required]
        string Ad { get; set; }
        [Required]
        string Soyad { get; set; }
        [Required]
        string Adres { get; set; }
        [Required]
        KanGrubulari KanGrubu { get; set; }
    }
}
