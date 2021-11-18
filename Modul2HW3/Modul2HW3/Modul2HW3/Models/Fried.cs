using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3.Models
{
    public abstract class Fried : FlourSweets
    {
        public TypeOfOil OilType { get; set; }
        public FryingVessel Vessel { get; set; }
    }
}
