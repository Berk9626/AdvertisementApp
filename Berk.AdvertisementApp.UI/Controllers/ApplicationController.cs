using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.UI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Controllers
{
	[Authorize(Roles ="Admin")]
	public class ApplicationController : Controller
	{
		private readonly IAdvertisementService _advertisementService;

		public ApplicationController(IAdvertisementService advertisementService)
		{
			_advertisementService = advertisementService;
		}

		public async Task<IActionResult> List()
		{
			var response = await _advertisementService.GetAllAsync();
			return this.ResponseView(response);
		}
	}
}
