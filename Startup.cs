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
using Microsoft.EntityFrameworkCore;
using MealPlanner.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MealPlanner
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

            

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
                        
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)    //"CookieAuth"
                .AddCookie("CookieAuth", config =>
                {
                    config.Cookie.Name = "User.Cookie";
                    config.LoginPath = "/Home/Index/";
                    //config.AccessDeniedPath = "/Home/Index/";
                });
            
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            //services.AddTransient<IUserRepository, UserRepository>();
            services.AddSession();
            //services.AddSingleton<>();
            //services.AddDbContext<Login>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
            // if I were to use identity services.ConfigureApplicationCookie(option => option.LoginPath = "/Home/Index");
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
            app.UseCookiePolicy();

            app.UseRouting();
            app.UseAuthentication();
            //app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                    
            });
        }
    }
}

//pattern: "{controller=UserRegistration}/{action=Create}/{id?}");