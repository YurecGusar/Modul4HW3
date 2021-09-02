using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW3.Configs.DBConfigs
{
    public class EmployeeConfig : IEntityTypeConfiguration<EmployeeProjectConfig>
    {
        public void Configure(EntityTypeBuilder<EmployeeProjectConfig> builder)
        {
        }
    }
}
