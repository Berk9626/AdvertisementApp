﻿using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.ValidationRules
{
	public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
	{
		public AppUserLoginDtoValidator()
		{
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz");

		}
	}
}
