using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW3.Services;

namespace Modul4HW3
{
    public class Starter
    {
        private AppConfigService _appConfig = new AppConfigService();

        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(_appConfig.ConnectionString);
            using (var db = new ApplicationContext(dbContext.Options))
            {
            }

            Console.WriteLine("Finish");
        }
    }
}
