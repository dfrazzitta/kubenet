using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using mvcfront.Data;


namespace mvcfront
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();
                      
            CreateDbIfNotExists(host);
             
            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            // this is a commit
            using IServiceScope scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError("Enter CreateDbIfNotExists");


                SchoolContext context = services.GetRequiredService<SchoolContext>();
                logger.LogError("After CreateDbIfNotExists");
                
                bool b = context.Database.EnsureCreated();
                logger.LogError("be4 initializer CreateDbIfNotExists");
                DbInitializer.Initialize(context);
                logger.LogError("after initializer CreateDbIfNotExists");
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An Error occurred creating the DB.");
            }
        }



        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
