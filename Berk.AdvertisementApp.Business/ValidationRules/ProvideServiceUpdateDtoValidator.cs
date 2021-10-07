using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.ValidationRules
{
	public class ProvideServiceUpdateDtoValidator: AbstractValidator<ProvideServiceUpdateDto>
	{

		public ProvideServiceUpdateDtoValidator()
		{
			RuleFor(x => x.Id).NotEmpty();
			RuleFor(x => x.Description).NotEmpty();
			RuleFor(x => x.Title).NotEmpty();
			RuleFor(x => x.ImagePath).NotEmpty();

		}

	}
}
