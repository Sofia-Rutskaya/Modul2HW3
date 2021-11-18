using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Services;
using Modul2HW3.Services.Abstractions;

namespace Modul2HW3
{
    public class Starter
    {
        private readonly UIService _uIService;

        public Starter()
        {
            _uIService = new UIService();
        }

        public void Run()
        {
            _uIService.Info("Jam", 15, 20);
        }
    }
}
