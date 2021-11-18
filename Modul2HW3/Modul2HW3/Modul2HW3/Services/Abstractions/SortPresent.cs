using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Services;
using Modul2HW3.Models;

namespace Modul2HW3.Services.Abstractions
{
    public class SortPresent : IComparer<Sweets>
    {
        private Sweets[] _present;
        private IPresentService _presents;

        public SortPresent()
        {
            _presents = PresentService.Instance;
            _present = _presents.GetPresent();
        }

        public int Compare(Sweets x, Sweets y)
        {
            if (y == null || x == null)
            {
                return 0;
            }

            if (x.Price < y.Price)
            {
                var a = x;
                x = y;
                y = a;

                return 1;
            }
            else if (x.Price > y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
