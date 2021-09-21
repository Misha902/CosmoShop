using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CosmoShop.Data;
using CosmoShop.Services;
using CosmoShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace CosmoShop
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = _config.GetConnectionString("DefaultConnection");
            services.AddDbContext<CosmoShopContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<StoreUser, IdentityRole>(cfg =>
                {
                    cfg.User.RequireUniqueEmail = true;
                })
                 .AddEntityFrameworkStores<CosmoShopContext>();
            services.AddAuthentication();


            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddRazorPages();
            services.AddTransient<IMailService, NullMailService>();
            services.AddScoped<ICosmoShopRepository, CosmoShopRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapRazorPages();

                cfg.MapControllerRoute("Default",
                    "/{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index" });
            });
        }
    }
}
