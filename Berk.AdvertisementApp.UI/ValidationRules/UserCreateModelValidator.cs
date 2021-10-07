using Berk.AdvertisementApp.UI.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.ValidationRules
{
	public class UserCreateModelValidator: AbstractValidator<UserCreateModel>
	{
		[Obsolete]
		public UserCreateModelValidator()
		{
			//CascadeMode = CascadeMode.StopOnFirstFailure; //ilk hatada bu işi durdur
			//password not empty ise dur
			
			RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz");
			RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola minimum 3 karakter olmalıdır");
			RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Şifreniz ilk şifrenizle eşleşmiyor. Tekrar kontrol ediniz.");
			RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kullanıcı adı 3 karakterden az olamaz");
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş olamaz");
			RuleFor(x => new { 
				x.UserName,
				x.FirstName
			
			
			}).Must(x=> CanNotFirstName(x.UserName, x.FirstName)).WithMessage("Kullanıcı adınızı adınızı içeremez").When(x=>x.UserName !=null && x.FirstName !=null); //username'in, firstname içermemesi için ikisine birden kural yazmamız lazım

			RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur.");
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad boş olamaz");
			


		}

		private bool CanNotFirstName(string userName, string firstName)
		{ //bu paremetrelerin içi null gelince sıkıntı yaşıyoruz ve yukarda when ile (şart şu iken) bu işi yap...Yani yukarda bu parametreler doluysa gel bunu hallet
			return !userName.Contains(firstName); //"123 içerirse burası  true döner  yukarda---- true dönerse ben bunu geçi kabul ederim diyor. Bu yüzden değilini alıyorum
			
		}
	}
}
