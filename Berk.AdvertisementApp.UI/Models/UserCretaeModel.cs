using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Models
{
	public class UserCreateModel //bu alanı gidip çeşitli şekilde mapleyeceğiz
	{ //bana genderlistDto gelmeli ki onun üzerinden hareket edebileyim.

		public string FirstName { get; set; }
		public string Surname { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }//eklediklerimiz var DTO dışında bu gibi

		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int GenderId { get; set; }
		public SelectList Genders { get; set; } //burdaki cinsiyetleri seletcListin içine setlemeyi unutma. Tüm Gender bilgileri gelsin, bunlardan birini seçip devam edeyim. !!!!

		//bu gendersları listeleyip, bu usercreatemodelle SignUpa dönmem lazım.

		//UI'de modele ihtiyacımız olmasının sebebi SelectListe ihtiyaç duyacağım.UI'de modele ihtiyacımız olacak.
		//Bir işimiz daha var. Modeli'de CreateDTO'ya çevireceğiz. UI'da tahmini. CreateDTO.Businessea gidip businessta ilgili işi gerçekleştirecek.



	}
}
