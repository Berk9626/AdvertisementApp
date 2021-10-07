using AutoMapper;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.Business.Mappings.AutoMapper;
using Berk.AdvertisementApp.Business.Services;
using Berk.AdvertisementApp.Business.ValidationRules;
using Berk.AdvertisementApp.DataAccess.Contexts;
using Berk.AdvertisementApp.DataAccess.UnitOfWork;
using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
	public static  class DependencyExtension
	{
		public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AdvertisementContext>(opt =>
			{
				opt.UseSqlServer(configuration.GetConnectionString("Local")); //bunu bu sefer AppSettingJsondan çekeceğim farklı olarak. UI'deki
			});

			//var mapperConfiguration = new MapperConfiguration(opt =>
			//{
			//	//opt.AddProfile()
			//	opt.AddProfile(new ProvideServiceProfile());
			//	opt.AddProfile(new AdvertisementProfile());
			//	opt.AddProfile(new AppUserProfile());
			//	opt.AddProfile(new GenderProfile());


			//});

			//var mapper = mapperConfiguration.CreateMapper();
			//services.AddSingleton(mapper); //dependency inj. ile bu sayede maperı ele alabiliyorum. Bulması ömür aldı ter akıttı :(
			//komple bu yukardakileri ayrı bir yerde yapmak istiyorum. Static bir extension method yazacağım

			services.AddScoped<IUow, Uow>();

			services.AddTransient<IValidator<ProvideServiceCreateDto>, ProvideServiceCreateDtoValidator>(); //sen constructorda ProvideServiceCreateDto gördüğün zaman ProvideServiceCreateDtoValidator'ı örnekle
			services.AddTransient<IValidator<ProvideServiceUpdateDto>, ProvideServiceUpdateDtoValidator>();
			services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
			services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
			services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
			services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
			services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
			services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();
			services.AddTransient < IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();
			services.AddTransient<IValidator<AdvertisementAppUserCreateDto>, AdvertisementAppUserCreateDtoValidator>(); 
			


			services.AddScoped<IProvideServiceService, ProvideServiceService>();
			services.AddScoped<IAdvertisementService, AdvertisementService>();
			services.AddScoped<IAppUserService, AppUserService>();
			services.AddScoped<IGenderService, GenderService>();
			services.AddScoped<IAdvertisementAppUserService, AdvertisementAppUserService>();

		}
	



			//var mapperConfiguration = new MapperConfiguration(opt =>
			//{//satır 43 yapılıyor, buraya yapıştırdım.
			//	//opt.AddProfile()
			//	opt.AddProfile();//içindeki newleri yukarı aldık.
			//	opt.AddProfile();
			//	opt.AddProfile();
			//	opt.AddProfile();


			//});

			//var mapper = mapperConfiguration.CreateMapper();
			//services.AddSingleton(mapper); //ekleme işlemini burada yapmayacağız. Hemen üstümüzde bir liste oluşturup o listeyi dönmek.

		
	}
}
