using Berk.Advertisement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Extensions
{//VALIDATE, ATAMA!!!
	public static class ValidationResultExtension //validationresultı genişletiyorum
	{//IServicedeki result aslında ValidationResult. Bu ValidationResulta method yazacağım. Yazdığım method geriye List<CustomValidationError> dönmeli
		public static List<CustomValidationError> ConvertToCustomValidationError(this FluentValidation.Results.ValidationResult validationResult) //this ile bunu genişlettim.Bu aslında result Service'deki.İlkinin
		{
			List<CustomValidationError> errors = new List<CustomValidationError>();

			foreach (var item in validationResult.Errors)
			{
				errors.Add(new CustomValidationError()
				{
					Message = item.ErrorMessage,
					PropertyName = item.PropertyName
				});
			}
			return errors;

		}
	}
}
