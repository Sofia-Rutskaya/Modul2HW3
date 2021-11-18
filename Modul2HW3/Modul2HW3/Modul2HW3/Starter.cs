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
        private readonly IUI _iui;
        private PresentService _presentService = PresentService.Instance;

        public Starter()
        {
            _iui = new UIService();
        }

        public void Run()
        {
            _presentService.SetPresent();
            _presentService.Sort();
            _iui.Info("Caramel", 17.2, 28.73);
            _iui.Info("Caramel", 15, 23);
        }
    }
}
