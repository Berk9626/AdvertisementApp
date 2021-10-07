using AutoMapper;
using Berk.Advertisement.Common;
using Berk.Advertisement.Common.Enums;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.UI.Extensions;
using Berk.AdvertisementApp.UI.Models;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Controllers
{
	public class AccountController : Controller
	{
		private readonly IGenderService _genderservice;
		private readonly IValidator<UserCreateModel> _userCreateModelValidator;
		//private readonly IValidator<AppUserLoginDto> _appUserLoginDto;
		private readonly IAppUserService _appUserService;
		private readonly IMapper _mapper;

		public AccountController(IGenderService service, IValidator<UserCreateModel> userCreateModelValidator, IAppUserService appUserService, IMapper mapper)
		{
			_genderservice = service;
			_userCreateModelValidator = userCreateModelValidator;
			_appUserService = appUserService;
			_mapper = mapper;
			
		}

		public async Task<IActionResult> SignUp() //user'ın creati
		{
			var response = await _genderservice.GetAllAsync();
			var model = new UserCreateModel
			{
				Genders = new SelectList(response.Data,"Id","Definition") //datavalue(Id),datatextfield(Definition) parametreleri ile ilgileniyoruz.
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> SignUp(UserCreateModel model)
		{
			var result = _userCreateModelValidator.Validate(model);
			if (result.IsValid)
			{   
				//lookup tablolar. Gender misal
				var dto = _mapper.Map<AppUserCreateDto>(model);
				var createResponse =  await _appUserService.CreateWithRoleAsync(dto, (int)RoleType.Member); //member rolüyle kaydetmek istediğim için service'e method ekkledim
				return this.ResponseRedirectAction(createResponse, "SignIn");
			}

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
			}

			var response = await _genderservice.GetAllAsync(); //bu 2 altakini yaptığımızda hatalı olsa bile yazdığımız isim, cinsiyet vs aynı yerinde kalıyor.
			model.Genders = new SelectList(response.Data, "Id", "Definition",model.GenderId); //diyelim ki post ettik hata oldu, gender gitmişti ama burda yukardaki gibi tekrar ele almamız gerekiyor.
			return View(model);
			
		}

		public  IActionResult SignIn()
		{
			return View(new AppUserLoginDto());
		}
		[HttpPost]
		public async Task<IActionResult> SignIn(AppUserLoginDto dto) //servisten yazacağım method gerek.
		{
			  
				var result = await _appUserService.CheckUserAsync(dto);
				if (result.ResponseType == ResponseType.Success)
				{ //TAMAMI MİCROSOFT DÖKÜMANLARINDAN KİMLİK DOĞRULAMA OLUŞTURMA COOKİE'NİN ALTINDAN

				   var roleResult = await _appUserService.GetRolesByUserIdAsync(result.Data.Id); //ilgili ıd'ye ait rolü ya da rolleri çektim.
				   var claims = new List<Claim>()
                   {    //claimlerde ilgili kullanıcının rollerini çekmem lazım.

                   };

				if (roleResult.ResponseType == ResponseType.Success)
				{
					foreach (var role in roleResult.Data)
					{
						claims.Add(new Claim(ClaimTypes.Role, role.Definition)); // artık kaç tane rolüm varsa...
					}

				}

				//ilgili arkadaşımızın rolü olmayabilir ama Id'sini tutmak istiyorum.Alttaki kodum
				claims.Add(new Claim( ClaimTypes.NameIdentifier, result.Data.Id.ToString()));


				   var claimsIdentity = new ClaimsIdentity(
					claims, CookieAuthenticationDefaults.AuthenticationScheme);

				   var authProperties = new AuthenticationProperties
				   { //IsPersistenti true geçersem o cookie bilgisini hatırlayacak.

					IsPersistent = dto.RememberMe
			       };

				    await HttpContext.SignInAsync(
					CookieAuthenticationDefaults.AuthenticationScheme,
					new ClaimsPrincipal(claimsIdentity),
					authProperties);
				

				return RedirectToAction("Index","Home");
			    }
				
			    ModelState.AddModelError("Kullanıcı adı veya şifre hatalı", result.Message);
			    return View(dto);
		}

		public async Task<IActionResult> LogOutAsync() //custom cokie based authentication----signout
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index","Home");

		}
	}
}
