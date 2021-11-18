using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3.Models
{
    public abstract class Baked : FlourSweets
    {
        public int OvenTemperature { get; set; }
    }
}
