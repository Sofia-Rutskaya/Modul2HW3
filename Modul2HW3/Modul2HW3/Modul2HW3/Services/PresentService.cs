using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Models;

namespace Modul2HW3.Services
{
    public class PresentService : IComparer<object>
    {
        private readonly ConfigService _config = ConfigService.Instance;
        private Jam _jam;
        private Jelly _jelly;
        private object[] _present;

        public PresentService()
        {
            _jam = new Jam();
            _jelly = new Jelly();
            _present = new object[10];
        }

        public void Sort(Jam jam, Jelly jelly)
        {
            Console.WriteLine("efw");
        }
    }
}
