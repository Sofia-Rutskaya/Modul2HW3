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
        private readonly IPresentService _ipresentService;

        public Starter()
        {
            _iui = new UIService();
            _ipresentService = PresentService.Instance;
        }

        public void Run()
        {
            _ipresentService.SetPresent();
            _ipresentService.Sort();
            _iui.Info("Caramel", 17.2, 28.73);
            _iui.Info("Caramel", 15, 23);
        }
    }
}
