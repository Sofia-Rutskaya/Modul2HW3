using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW3.Configs;

namespace Modul2HW3.Services
{
    public class ConfigService
    {
        private static readonly ConfigService _instance = new ConfigService();

        static ConfigService()
        {
        }

        private ConfigService()
        {
            var config = GetConfig();
        }

        public static ConfigService Instance => _instance;

        public Config GetConfig()
        {
            return new Config
            {
                SizeOfPresent = 10
            };
        }

        public int GetSizeOfPresent()
        {
            return GetConfig().SizeOfPresent;
        }
    }
}
