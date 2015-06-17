using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEntity
{
    interface INonHuman
    {
        [Required]
        string Ad { get; set; }
    }
}
