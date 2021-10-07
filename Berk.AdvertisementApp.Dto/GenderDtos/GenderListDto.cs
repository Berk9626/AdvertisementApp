using Berk.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Dtos
{
	public class  GenderListDto :IDto
	{ //normalde Genderı create etmeyeceğiz ama normal durum bu olduğu için yazmak istedim
	//bu lookup table'lar için sadece List içeren bir servis yazabiliriz. Yani generic service'den implemente değilş de, geriye sadece list döneen bir şey yazabiliriz, ya da generic servisi işin içine dahil etmeden bir repository yazıp, interfacisini de eklediğimizde sadece get çalışır gibi.Bu yapıdan devam edeceğim
	//	
		public int Id { get; set; }
		public string Definition { get; set; }

	}
}
