using Business.Abstract;
using Business.Concrete;
using Business.Container;
using Data.Abstract;
using Data.Concrete;
using Data.Concrete.EntityFramwork;
using Entity;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.Models;

namespace TraversalCoreProje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });
            services.ConfigureApplicationCookie(options => { options.LoginPath = "/Account/Login"; });
            services.AddScoped<GetAllDestinationQueryHandler>();
            services.AddScoped<GetDestinationByIdHandler>();
            services.AddScoped<CreateDestinationHandler>();
            services.AddScoped<DeleteDestinationHandler>();
            services.AddScoped<UpdateDestinationHandler>();
            services.AddMediatR(typeof(Startup));
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();
            services.AddHttpClient();
            services.ContainerDependencies();
            services.AddAutoMapper(typeof(Startup));
            services.CustomerValidator();

            services.AddControllersWithViews().AddFluentValidation();


            services.AddMvc(
               config =>
               {
                   var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                   config.Filters.Add(new AuthorizeFilter(policy));
               }
               );

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");
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

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?GetHashCode ={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();



            //var supportedCultures = new List<CultureInfo>{
            //         new CultureInfo("tr-TR"),
            //         new CultureInfo("en-US"),
            //         new CultureInfo("fr-FR")
            //    };
            // SupportedCultures ve SupportedUICultures'a yukarýda oluþturduðumuz dil listesini tanýmlýyoruz.
            // DefaultRequestCulture'a varsayýlan olarak uygulamamýzýn hangi dil ile çalýþmasý gerektiðini tanýmlýyoruz.

            //var localizationOptions = new RequestLocalizationOptions
            //{
            //    SupportedCultures = supportedCultures,
            //    SupportedUICultures = supportedCultures,
            //    DefaultRequestCulture = new RequestCulture("tr-TR"),
            //};

            //app.UseRequestLocalization(localizationOptions);








            // Dil ayarlarýný ve varsayýlan dil seçimini tanýmlýyoruz.
            //var localizationOptions = new RequestLocalizationOptions
            //{
            //     SupportedCultures = supportedCultures,
            //     SupportedUICultures = supportedCultures,
            //     DefaultRequestCulture = new RequestCulture("tr-TR"),
            //};
            var supputedCultures = new[] { "en", "fr", "tr" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supputedCultures[2]).AddSupportedCultures(supputedCultures).AddSupportedUICultures(supputedCultures);
            app.UseRequestLocalization(localizationOptions);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });


        }
    }
}
