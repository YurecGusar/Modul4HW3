using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modul4HW3.Services;
using Modul4HW3.Services.Abstractions;

namespace Modul4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAppConfigService, AppConfigService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
