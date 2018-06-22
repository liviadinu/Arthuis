using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ArthuisWebShop.Models.Interfaces;
using ArthuisWebShop.Models.Repositories;

namespace ArthuisWebShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //dependency injection container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISkuItemsList, MockItemRepo>();
            //services.AddSingleton
            //services.AddScoped
            services.AddMvc();
            services.AddNodeServices();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            //app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default",
                  "{controller}/{action}/{id?}",
                  new { controller = "Home", Action = "Index" });
            });

        }
    }
}
