using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mvcfront.Data;
using Microsoft.EntityFrameworkCore;
using Prometheus;

namespace mvcfront
{
    public class Startup
    {
        private string _flag;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

             _flag = Configuration.GetValue<string>("sqlChoice");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

             services.AddHealthChecks()
                .AddCheck<RandomResultCheck>("random_check");
                //.ForwardToPrometheus();

             if (_flag.CompareTo("SchoolContext")==0) 
            {
                services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("sqldata18")));
            }
            if (_flag.CompareTo("sqldatacompose") == 0)
            {
                services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("sqldatacompose")));
            }
            if (_flag.CompareTo("mydb") == 0) // in cluster
            {
                services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("mydb")));
            }
            if (_flag.CompareTo("sqldata18") == 0) // in cluster
            {
                services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("sqldata18")));
            }
 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           // app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

          //  app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapMetrics();
                endpoints.MapHealthChecks("/health");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
