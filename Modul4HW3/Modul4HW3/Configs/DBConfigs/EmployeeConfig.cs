using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW3.Models;

namespace Modul4HW3.Configs.DBConfigs
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.EmployeeId);
            builder.Property(a => a.EmployeeId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.FirstName).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(b => b.LastName).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(c => c.HiredData).IsRequired().HasMaxLength(7).HasColumnType("datetime2");
            builder.Property(c => c.DataOfBirth).HasColumnType("date");
            builder.HasOne(d => d.Office)
                .WithMany(d => d.Employes)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Title)
                .WithMany(e => e.Employes)
                .HasForeignKey(e => e.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
