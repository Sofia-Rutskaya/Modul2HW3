using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Services.Abstractions;

namespace Modul2HW3.Services
{
    public class UIService : IUI
    {
        private PresentService _presentService = PresentService.Instance;

        public virtual double GetWeight()
        {
            return 0;
        }

        void IUI.Info(string name, double price, double weigh)
        {
            var message = string.Empty;

            var candy = _presentService.FindSweet(name, price, weigh);
            if (candy == null)
            {
                message = "Candy not found";
            }
            else
            {
                message = "Candy is in the present";
            }

            Console.WriteLine($"Weight of present: {new WeightService().GetWeight()}, Found candy: {message}");
        }
    }
}
