using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.ValidationRules
{
	public class ProvideServiceCreateDtoValidator: AbstractValidator<ProvideServiceCreateDto>
	{
		public ProvideServiceCreateDtoValidator()
		{
			RuleFor(x => x.Description).NotEmpty(); //Will return an error if null or empty
			RuleFor(x => x.ImagePath).NotEmpty();
			
		}
	}
}
