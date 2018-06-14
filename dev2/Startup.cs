using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dev2.Data;
using dev2.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace dev2
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration  config)
        {
            _config = config;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Dev2Context>(cfg =>
            {
                //cfg.UseSqlServer(_config.GetConnectionString("Dev2ConnectionString"));
                cfg.UseSqlServer("server = (localdb)\\ProjectsV13; Database = DevDb; Integrated Security = true;");



            }
            );




            services.AddTransient<IMailService, NullMailService>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseDeveloperExceptionPage();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            app.UseStaticFiles();

            app.UseMvc(cfg =>
            {
                cfg.MapRoute("default", "{controller}/{action}/{id?}",  new { controller = "App", Action = "Index" });
            });

           
            

        }
    }
}
