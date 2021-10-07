using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.ValidationRules
{
	public class AdvertisementUpdateDtoValidator: AbstractValidator<AdvertisementUpdateDto>
	{
		public AdvertisementUpdateDtoValidator()
		{
			RuleFor(x => x.Id).NotEmpty(); //ıD BOŞ BIRAKTIĞIN ZAMAN ya da 0 verdiğin zaman bu validation kuralı geçersiz
			RuleFor(x => x.Description).NotEmpty();
			RuleFor(x => x.Title).NotEmpty();
		}
	}
}
