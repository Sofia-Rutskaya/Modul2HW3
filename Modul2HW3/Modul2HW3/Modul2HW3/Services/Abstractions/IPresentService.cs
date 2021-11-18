using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Models;

namespace Modul2HW3.Services.Abstractions
{
    public interface IPresentService
    {
        public Sweets[] GetPresent();
        public void Sort();
        public void SetPresent();
        public object FindSweet(string name, double price, double weigh);
    }
}
