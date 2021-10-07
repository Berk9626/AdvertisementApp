using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.UI.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Controllers
{
	public class HomeController : Controller
	{

		private readonly IProvideServiceService _provideServiceServices;
		private readonly IAdvertisementService _advertisementService;

		public HomeController(IProvideServiceService provideServiceServices, IAdvertisementService advertisementService)
		{
			_provideServiceServices = provideServiceServices;
			_advertisementService = advertisementService;
		}

		public async Task<IActionResult> Index()
		{
			var response = await _provideServiceServices.GetAllAsync();
			return this.ResponseView(response); //geriye provideservicelistdto dönüyor.
		}
		public async Task<IActionResult> HumanResource()
		{
			var response = await _advertisementService.GetActivesAsync();
			return this.ResponseView(response);
		}

		//ilk önce DTO oluştur,
		// daha sonra dtovalidatorları(validationRules) oluştur.
		//Daha sonra bu validatorları Microsoft extensiona kaydet
		//Sonra MapProfileını oluştur
		//Bunu extensioana kaydet
		//Sonra gel ilgili Servisini ve interfacesini yaz, (servisinde ek bir şey eklediysen  Dependencyextensiona git Addscoped ile ekle vs.)
		//Sonrada gel UI'Da kullan. Controllerda servisi tanımla bir bira içer gibi, güzel bir kızı keser gibi keyfine bak :))))
		//bu anlattıklarım kurumsal bir firmada aslında bir yazılımcının yapması gereken maddelerin tek tek sıralı şekli. Okuyana selam olsun vesselam XD XD
		

	}
}
