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
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(a => a.OfficeId);
            builder.Property(a => a.OfficeId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.Title).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(a => a.Location).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
