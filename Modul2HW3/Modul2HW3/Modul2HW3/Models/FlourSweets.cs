using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3.Models
{
    public abstract class FlourSweets : Sweets
    {
        public int PercentOfFlour { get; set; }
        public TypeOfFlour Type { get; set; }
    }
}
