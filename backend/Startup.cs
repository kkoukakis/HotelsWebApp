using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
// using HotelsWebApp.Extensions;
using HotelsWebApp.Models;



namespace HotelsWebApp
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
            services.AddControllersWithViews();
            services.AddDbContext<WdaContext>();
            services.AddMvc();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
           
            // ADD AUTHENTICATION
            // services.AddIdentity<User, UserRole>().AddDefaultTokenProviders();
            // services.AddTransient<IUserStore<User>, UserStore>();
            // services.AddTransient<IRoleStore<UserRole>, RoleStore>();
			
            
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
            
            // IMPORTANT: This session call MUST go before UseMvc()
            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapControllerRoute(
                    name: "filteredList",
                    pattern: "/Login",
                    defaults: new{
                        controller ="Account",
                        action = "Login"
                    }
                );

                  endpoints.MapControllerRoute(
                    name: "filteredList",
                    pattern: "/Room",
                    defaults: new{
                        controller ="Home",
                        action = "Room"
                    }
                );

                      endpoints.MapControllerRoute(
                    name: "filteredList",
                    pattern: "/Roomlist",
                    defaults: new{
                        controller ="Home",
                        action = "Roomlist"
                    }
                );

                


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
              
            });
        }
    }
}
