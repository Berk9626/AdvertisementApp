using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Dtos
{
	public class AdvertisementAppUserListDto
	{//appuserdan kopyaladık

		public int Id { get; set; }
		public int AdvertisementId { get; set; }
		public AdvertisementListDto Advertisement { get; set; } //değişti
		public int AppUserId { get; set; }
		public AppUserListDto AppUser { get; set; }//değişti değişenlerin tek tek mappinglerini check ettik

		public int AdvertisementAppUserStatusId { get; set; }
		public AdvertisementAppUserStatusListDto AdvertisementAppUserStatus { get; set; }  //değişti, mappingini ekledik.
		public int MilitaryStatusId { get; set; }
		public MilitaryStatusListDto MilitaryStatus { get; set; } //değişti
		public DateTime? EndDate { get; set; } //ilgili militarystatusa göre belirlenecek, tecilliyse EndDate'e setleyecektik
		public int WorkExperience { get; set; }
		public string CvPath { get; set; }
	}
}
