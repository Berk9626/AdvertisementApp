using Berk.Advertisement.Common;
using Berk.Advertisement.Common.Enums;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.UI.Extensions;
using Berk.AdvertisementApp.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Controllers
{
	public class AdvertisementController : Controller
	{
		private readonly IAppUserService _appUserService;
		private readonly IAdvertisementAppUserService _advertisementAppUserService;

		public AdvertisementController(IAppUserService appUserService, IAdvertisementAppUserService advertisementAppUserService)
		{
			_appUserService = appUserService;
			_advertisementAppUserService = advertisementAppUserService;
		}

		public IActionResult Index()
		{
			return View();
		}
		[Authorize(Roles ="Member")]
		public async Task<IActionResult> Send(int advertisementId) //kişi başvuru işlemi yapıyor. Bunu yapabilmesi için de giriş yapması lazım
		{
			var userId = int.Parse( (User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value); //userId(girerken girdiğim memberın).Sallıyorum 3 numaralı userıd, 4 nmaralı advertisemente gelmiş
																												   //bu userıd ile Service gidip Puser çekmem lazım.Altta
			var userResponse = await _appUserService.GetByIdAsync<AppUserListDto>(userId);
			//yani bir nevi Id'si ile griş yaptığım userId'yi çektim. Sonra bu userId'yi servisten çekince bu kullanıcıma erişmiş oldum içindeki bütün bilgilere.Burdan gender bilgisini de alıp devam edebilirim.
			
			//bir şekilde gender bilgisini Viewbagte tutacağım
			ViewBag.GenderId = userResponse.Data.GenderId;

			var items = Enum.GetValues(typeof(MilitaryStatusType));
			var list = new List<MilitaryStatusListDto>();

			foreach (int item in items) //int olarak değiştirince enum itemler sayı olarak geldi
			{
				list.Add(new MilitaryStatusListDto()
				{
					Id = item,
					Definition = Enum.GetName(typeof(MilitaryStatusType),item) //bana verdiğin tipin id 'sini de ver ben sana adını getiririm diyoruz
				});
			}

			ViewBag.MilitaryStatus = new SelectList(list, "Id", "Definition");
			

			return View(new AdvertisementAppUserCreateModel{ 
			AdvertisementId = advertisementId,
			AppUserId = userId,
			
			});
		}

		[Authorize(Roles = "Member")]
		[HttpPost]
		public async Task<IActionResult> Send(AdvertisementAppUserCreateModel model)
		{
			AdvertisementAppUserCreateDto dto = new AdvertisementAppUserCreateDto();
			if (model.CvFile != null )
			{
				var fileName = Guid.NewGuid().ToString();
				var extName = Path.GetExtension(model.CvFile.FileName);
				string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","cvFiles", fileName+extName);//uygulamanın çalıştığı yere git, sonra o yerle wwwrootu birleştirburda da files alanında bir yer koy ve bu cvfiles dosyasını ekle ismiyle
				var stream = new FileStream(path, FileMode.Create);
				await model.CvFile.CopyToAsync(stream);     //streami bu arkadaşa gönderiyoruz.
				dto.CvPath = path;

			}

			dto.AdvertisementAppUserStatusId = model.AdvertisementAppUserStatusId;
			dto.AdvertisementId = model.AdvertisementId;
			dto.AppUserId = model.AppUserId;
			dto.EndDate = model.EndDate;
			dto.MilitaryStatusId = model.MilitaryStatusId;
			dto.WorkExperience = model.WorkExperience;

			var response = await _advertisementAppUserService.CreateAsync(dto);
			if (response.ResponseType == ResponseType.ValidationError)
			{
				foreach (var error in response.ValidationErrors)
				{
					ModelState.AddModelError(error.PropertyName, error.Message);

				}
				//copy-pasteykr
				var userId = int.Parse((User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value); //userId(girerken girdiğim memberın).Sallıyorum 3 numaralı userıd, 4 nmaralı advertisemente gelmiş
																													  //bu userıd ile Service gidip Puser çekmem lazım.Altta
				var userResponse = await _appUserService.GetByIdAsync<AppUserListDto>(userId);
				//yani bir nevi Id'si ile griş yaptığım userId'yi çektim. Sonra bu userId'yi servisten çekince bu kullanıcıma erişmiş oldum içindeki bütün bilgilere.Burdan gender bilgisini de alıp devam edebilirim.

				//bir şekilde gender bilgisini Viewbagte tutacağım
				ViewBag.GenderId = userResponse.Data.GenderId;
				//copy-pasteykr
				var items = Enum.GetValues(typeof(MilitaryStatusType));
				var list = new List<MilitaryStatusListDto>();

				foreach (int item in items) //int olarak değiştirince enum itemler sayı olarak geldi
				{
					list.Add(new MilitaryStatusListDto()
					{
						Id = item,
						Definition = Enum.GetName(typeof(MilitaryStatusType), item) //bana verdiğin tipin id 'sini de ver ben sana adını getiririm diyoruz
					});
				}

				ViewBag.MilitaryStatus = new SelectList(list, "Id", "Definition");
				return View(model);
			}
			else
			{
				return RedirectToAction("HumanResource", "Home");
			}

			//başvuru yapma
			//yapılmış başvurularım
			//yapılan başvuruları gösterme(state=başvuru) reddedilen onaylanan
			
		} 
		[Authorize(Roles ="Admin")]
		public async Task< IActionResult> List()
		{
			var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Basvurdu);
			
			return View(list);
		}

		[Authorize(Roles ="Admin")]
		public async Task<IActionResult> SetStatus(int advertisementAppUserId, AdvertisementAppUserStatusType type)
		{
			await _advertisementAppUserService.SetStatusAsync(advertisementAppUserId, type);
			
			return RedirectToAction("List");
		}
		[Authorize(Roles ="Admin")]
		public async Task<IActionResult> ApprovedList()
		{
			var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Mulakat);
			return View(list);
		}
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> RejectedList()
		{
			var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Olumsuz);
			return View(list);
		}
	}
}
