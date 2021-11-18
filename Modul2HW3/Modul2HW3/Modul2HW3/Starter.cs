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
        private readonly PresentService _presentService;

        public Starter()
        {
            _presentService = PresentService.Instance;
        }

        public void Run()
        {
            _presentService.SetPresent();
            _presentService.Sort();
        }
    }
}
