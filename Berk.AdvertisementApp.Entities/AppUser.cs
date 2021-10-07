using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Entities
{
	//NOT1
	//bunu UI'de inşa etme şeklim
	//1-Klasik HomeController'da yazdığım gibi Update,Create ve listi default ListCreateDto'ları hazırlanacak
	//sonra mappingler, Interfacesi yazılıyor, sonra classı yazılıyor ve işimiz finito
	//DEPENDENCY RESOLVERA BAĞIMLILIKLARIMIZI EKLİYORUZ !!!!
	

	public class AppUser : BaseEntity
	{
		//public int Id { get; set; }
		public string FirstName { get; set; }
		public string Surname { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int GenderId { get; set; }
		public Gender Gender { get; set; }

		public List<AppUserRole> AppUserRoles { get; set; }
		public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }

	}
}
