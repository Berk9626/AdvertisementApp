﻿using Berk.Advertisement.Common.Enums;
using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.ValidationRules
{
	public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
	{
		public AdvertisementAppUserCreateDtoValidator()
		{
			this.RuleFor(x => x.AdvertisementAppUserStatusId).NotEmpty();
			this.RuleFor(x => x.AdvertisementId).NotEmpty();
			this.RuleFor(x => x.AppUserId).NotEmpty();
			this.RuleFor(x => x.CvPath).NotEmpty().WithMessage("Bir cv dosyası seçiniz");
			this.RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusId == (int)MilitaryStatusType.Tecilli).WithMessage("Tecil tarihi boş bırakılamaz");
			
		}
	}
}
