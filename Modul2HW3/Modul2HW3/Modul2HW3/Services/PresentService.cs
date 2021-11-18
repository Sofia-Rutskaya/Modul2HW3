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
                Weigh = 20.7,
                PiecesOfFruit = true,
                Base = BaseType.Apple,
                PercentOfSugar = 68,
                NumberOfBrewingProcesses = 1
            });
            Add(new Jam()
            {
                Name = "Jam",
                Price = 15,
                Weigh = 20,
                Base = BaseType.Cherry,
                DryMatterConcentration = 60,
                NumberOfBrewingProcesses = 5,
                PercentOfSugar = 80
            });
            Add(new Paste()
            {
                Name = "Paste",
                Price = 24.5,
                Weigh = 26.4,
                Base = BaseType.BlackCurrant,
                PercentOfSugar = 65,
                PercentageOfHardness = 78
            });
            Add(new Caramel()
            {
                Name = "Paste",
                Price = 17.2,
                Weigh = 28.73,
                PercentOfSugar = 73,
                PercentageOfHardness = 95,
                Filling = true,
                PlacedOnAStick = false
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
