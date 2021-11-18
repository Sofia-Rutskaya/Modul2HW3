using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW3.Models
{
    public class Donut : Fried
    {
        public GlazeType Glase { get; set; }
        public BaseType Filling { get; set; }
    }
}
