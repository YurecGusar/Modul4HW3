using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4HW3.Models;
using Microsoft.EntityFrameworkCore;
using Modul4HW3.Configs.DBConfigs;

namespace Modul4HW3.Services
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfig());
            builder.ApplyConfiguration(new EmployeeProjectConfig());
            builder.ApplyConfiguration(new OfficeConfig());
            builder.ApplyConfiguration(new ProjectConfig());
            builder.ApplyConfiguration(new TitleConfig());
        }
    }
}
