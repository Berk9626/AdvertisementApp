using AutoMapper;
using Berk.AdvertisementApp.Business.DependencyResolvers.Microsoft;
using Berk.AdvertisementApp.Business.Helpers;
using Berk.AdvertisementApp.UI.Mappings.AutoMapper;
using Berk.AdvertisementApp.UI.Models;
using Berk.AdvertisementApp.UI.ValidationRules;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public IConfiguration Configuration { get; set; } //burdan alttaki Startup ctoru da dahil ikisi appsettingjsonda database tanýmladýðýmýz için zorunlu olarak yapmamýz gerekendi.Alta conf.Getconnectionstring.
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDependencies(Configuration); //sql için
			services.AddTransient<IValidator<UserCreateModel>, UserCreateModelValidator>();


			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt=> {   // microsoft dökümanlarýndan(custom cookie based authentication microsoft)

				opt.Cookie.Name = "BerkCookie";
				opt.Cookie.HttpOnly = true; //js
				opt.Cookie.SameSite = SameSiteMode.Strict; //cookie paylaþýma kapalý
				opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; //http vyea https neyle gelirse onla çalýþsýn cookie
				opt.ExpireTimeSpan = TimeSpan.FromDays(20);
				opt.LoginPath = new PathString("/Account/SignIn"); //yetkisiz durum kodu, buraya gitsin
				opt.LogoutPath = new PathString("/Account/LogOut");
				opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
			});

			services.AddControllersWithViews();//controller için


			var profiles = ProfileHelper.GetProfiles();//dependency ext. geldim. STATÝC BÝR CLASS BURDA YAZMAMAM LAZIM.
			profiles.Add(new UserCreateModelProfile());

			var configuration = new MapperConfiguration(opt =>
			{
				opt.AddProfiles(profiles);
			});
			var mapper = configuration.CreateMapper();
			services.AddSingleton(mapper);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication(); // microsoft dökümanlarýndan(custom cookie based authentication microsoft)
			app.UseAuthorization(); // microsoft dökümanlarýndan(custom cookie based authentication microsoft)

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});
		}
	}
}
