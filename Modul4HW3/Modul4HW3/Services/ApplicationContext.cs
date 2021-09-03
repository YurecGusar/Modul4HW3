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
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }

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
