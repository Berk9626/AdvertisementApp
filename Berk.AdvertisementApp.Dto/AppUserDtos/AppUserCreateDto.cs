using Berk.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Dtos
{
	public class AppUserCreateDto :IDto
	{
		public string FirstName { get; set; }
		public string Surname { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int GenderId { get; set; }

		//UI'de modele ihtiyacımız olmasının sebebi SelectListe ihtiyaç duyacağım.UI'de modele ihtiyacımız olacak.
		//Bir işimiz daha var. Modeli'de CreateDTO'ya çevireceğiz. UI'da tahmini. CreateDTO.Businessea gidip businessta ilgili işi gerçekleştirecek.

		

	}
}
