using Berk.Advertisement.Common.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Models
{
	public class AdvertisementAppUserCreateModel
	{
		public int AdvertisementId { get; set; }
		public int AppUserId { get; set; }
		//bunun default değeri basvurdu değeri neyse
		public int AdvertisementAppUserStatusId { get; set; } = (int)AdvertisementAppUserStatusType.Basvurdu; //bunu default bir değer olarak atamamız lazım.Zorunlu olmayacak
		public int MilitaryStatusId { get; set; }
		public DateTime? EndDate { get; set; }
		public int WorkExperience { get; set; }
		public IFormFile CvFile { get; set; }
	}
}
