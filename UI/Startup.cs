using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using DAL;
using DAL.Products;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
/// <summary>
/// This is for branch test today 981203 3:45
/// </summary>

namespace UI
{
    public class Startup
    {
        public IConfiguration _Cfg ;
        public Startup(IConfiguration MyStoreCfg)
        {
            _Cfg = MyStoreCfg;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(mvcopt=>mvcopt.EnableEndpointRouting=false);
            services.AddScoped<IProductRepository, EFProductRepositpry>();
            services.AddDbContext<MyStorContex>(c => c.UseSqlServer(_Cfg.GetConnectionString("MyStore")), ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseMvc(routes=> { routes.MapRoute(name: "FirstRoute", template: "{controller=product}/{action=ShowAllProducts}/{id?}"); });
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            

            
        }
    }
}
