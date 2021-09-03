using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Modul4HW3.Configs;
using Modul4HW3.Services.Abstractions;

namespace Modul4HW3.Services
{
    public class AppConfigService : IAppConfigService
    {
        private const string _configPath = "config.json";
        public AppConfigService()
        {
            var config = GetConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; }

        private AppConfig GetConfig()
        {
            var json = File.ReadAllText(_configPath);
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }

        private void Ser()
        {
            var json = JsonConvert.SerializeObject(GetCon());
            File.WriteAllText(_configPath, json);
        }

        private AppConfig GetCon()
        {
            return new AppConfig()
            {
                ConnectionString = "Server = localhost,1433; Database = HW4_db; User = sa; Password = PassW0rd;"
            };
        }
    }
}
