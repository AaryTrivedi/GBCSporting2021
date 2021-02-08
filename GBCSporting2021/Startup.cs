using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GBCSporting2021.Models;

namespace GBCSporting2021
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            services.AddControllersWithViews();

            services.AddDbContext<Context>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DbContext"))
            );
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "ListProducts",
                    pattern: "{controller=Product}/{action=List}/"
                );

                endpoints.MapControllerRoute(
                    name: "AddProduct",
                    pattern: "{controller=Product}/{action=Add}/"
                );

                endpoints.MapControllerRoute(
                    name: "CreateProduct",
                    pattern: "{controller=Product}/{action=Create}"
                );

                endpoints.MapControllerRoute(
                    name: "ListTechnicians",
                    pattern: "{controller=Technician}/{action=List}/"
                );

                endpoints.MapControllerRoute(
                    name: "AddTechnician",
                    pattern: "{controller=Technician}/{action=Add}/"
                );

                endpoints.MapControllerRoute(
                    name: "CreateTechnician",
                    pattern: "{controller=Technician}/{action=Create}"
                );

                endpoints.MapControllerRoute(
                    name: "ListCustomers",
                    pattern: "{controller=Customer}/{action=List}/"
                );

                endpoints.MapControllerRoute(
                    name: "ListIncidents",
                    pattern: "{controller=Incident}/{action=List}"
                );
            });
        }
    }
}
