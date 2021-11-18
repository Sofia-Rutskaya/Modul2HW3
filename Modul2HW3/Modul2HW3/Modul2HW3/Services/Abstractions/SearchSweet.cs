using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Models;

namespace Modul2HW3.Services.Abstractions
{
    public static class SearchSweet
    {
        static SearchSweet()
        {
        }

        public static Sweets FindSweet(string name, double price, double weigh, Sweets[] present)
        {
            for (var i = 0; i < present.Length; i++)
            {
                if (present[i] == null)
                {
                    return null;
                }

                if (present[i].Name == name && present[i].Price == price && present[i].Weigh == weigh)
                {
                    return present[i];
                }
            }

            return null;
        }
    }
}
