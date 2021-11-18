using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Models;
using Modul2HW3.Services.Abstractions;

namespace Modul2HW3.Services
{
    public class WeightService : UIService
    {
        private readonly Sweets[] _present;
        private IPresentService _presents;
        private double _weigh;

        public WeightService()
        {
            _presents = PresentService.Instance;
            _present = _presents.GetPresent();
        }

        public override double GetWeight()
        {
            for (var i = 0; i < _present.Length; i++)
            {
                if (_present[i] == null)
                {
                    break;
                }

                _weigh += _present[i].Weigh;
            }

            return _weigh;
        }
    }
}
