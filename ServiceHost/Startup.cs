using _0_FrameWork.Application;
using _01_Framework.Application;
using AccountManagement.Infrastrue.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StoreManager.Infrastrue.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost
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

            var connection = Configuration.GetConnectionString("AuthenticationDB");

            ShopBootstraper.Config(services, connection);
            AccountBootstraper.Config(services, connection);


            services.AddTransient<IFileUploader, FileUplouder>();
            services.AddTransient<IAuthHelper, AuthHelper>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();

            services.AddHttpContextAccessor();

            //Cookie
            services.Configure<CookiePolicyOptions>(options =>
                options.MinimumSameSitePolicy=SameSiteMode.Lax
            );

            services.AddSession(options =>
            {
                options.IOTimeout = TimeSpan.FromDays(1);
                options.Cookie.SameSite = SameSiteMode.Lax;
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
           {
               o.LoginPath = new PathString("/Account");
               o.LogoutPath = new PathString("/Account");
               o.AccessDeniedPath = new PathString("/AccessDenied");
           });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminArea", Bulder => Bulder.RequireRole("1"));
                options.AddPolicy("Shop", Bulder => Bulder.RequireRole("1"));
            });

            services.AddRazorPages().AddMvcOptions(x => x.Filters.Add<SecurityPageFilter>())
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeAreaFolder("Administration", "/", "AdminArea");
                    options.Conventions.AuthorizeAreaFolder("Administration", "/Shop", "Shop");
                }); ;
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
