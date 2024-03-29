using BookStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; set; }

        public Startup (IConfiguration temp)
        {
            Configuration = temp;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<BookstoreContext>(options =>
           {
               options.UseSqlite(Configuration["ConnectionStrings:BookStoreDBConnection"]);
           });

            services.AddScoped<IBookStoreRepo, EFBookStoreRepo>();
            services.AddScoped<IPurchaseRepo, EFPurchaseRepo>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor > ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                //Change URL to a more user friendly wording
                
                endpoints.MapControllerRoute(
                    "categorypage",
                    "{bookCategory}/Page{pgNum}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                   name: "Paging",
                   pattern: "Page{pgNum}",
                   defaults: new { Controller = "Home", action = "Index", pgNum = 1 });

                endpoints.MapControllerRoute(
                    "category",
                    "{bookCategory}",
                    new { Controller = "Home", action = "Index", pgNum = 1 });


               

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }
    }
}
