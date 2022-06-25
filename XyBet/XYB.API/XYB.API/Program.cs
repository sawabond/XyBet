using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYB.API.Options;
using XYB.Data;
using XYB.Data.Entities;

namespace XYB.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var build = CreateHostBuilder(args).Build();

            using (var scope = build.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationContext>();

                if (!context.Set<AppRole>().Any())
                {
                    var roleManager = services.GetRequiredService<RoleManager<AppRole>>();

                    await roleManager.CreateAsync(new AppRole { Name = Roles.User });
                    await roleManager.CreateAsync(new AppRole { Name = Roles.Admin });
                    await roleManager.CreateAsync(new AppRole { Name = Roles.Moder });
                    await roleManager.CreateAsync(new AppRole { Name = Roles.Support });
                }
            }

            build.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
