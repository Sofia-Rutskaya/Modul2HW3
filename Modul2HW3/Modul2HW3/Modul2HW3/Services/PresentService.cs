using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Models;
using Modul2HW3.Services.Abstractions;

namespace Modul2HW3.Services
{
    public class PresentService
    {
        private readonly ConfigService _config = ConfigService.Instance;
        private static readonly PresentService _instance = new PresentService();
        private object _sweet;
        private Sweets[] _present;

        static PresentService()
        {
        }

        private PresentService()
        {
            _sweet = new object();
            _present = new Sweets[_config.GetSizeOfPresent()];
        }

        public static PresentService Instance => _instance;

        public Sweets[] GetPresent()
        {
            return _present;
        }

        public void Sort()
        {
            Array.Sort(_present, new SortPresent());
        }

        public object FindSweet(string name, double price, double weigh)
        {
            return SearchSweet.FindSweet(name, price, weigh, _present);
        }

        public void SetPresent()
        {
            Add(new Jelly()
            {
                Name = "ks",
                Price = 15,
                Weigh = 20,
                PiecesOfFruit = true,
                Base = BaseType.Apple,
                PercentOfSugar = 68,
                NumberOfBrewingProcesses = 1
            });
            Add(new Jam()
            {
                Name = "Lam",
                Price = 25,
                Weigh = 15,
                Base = BaseType.Cherry,
                DryMatterConcentration = 60,
                NumberOfBrewingProcesses = 5,
                PercentOfSugar = 80
            });
            Add(new Jelly()
            {
                Name = "OGGus",
                Price = 20,
                Weigh = 40,
                PiecesOfFruit = false,
                Base = BaseType.BlackCurrant,
                PercentOfSugar = 64,
                NumberOfBrewingProcesses = 1
            });
        }

        private void Add(Sweets sweets)
        {
            for (var i = 0; i < _present.Length; i++)
            {
                if (_present[i] == null)
                {
                    _present[i] = sweets;
                    break;
                }
            }
        }
    }
}
