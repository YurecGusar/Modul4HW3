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
        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer("Server = localhost,1433; Database = HW4_db; User = sa; Password = Passw0rd;");
            using (var db = new ApplicationContext(dbContext.Options))
            {
            }

            Console.WriteLine("END");
        }
    }
}
