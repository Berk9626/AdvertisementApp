﻿using Berk.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Dtos
{
	public class AdvertisementAppUserCreateDto : IDto
	{
		public int AdvertisementId { get; set; }
		public int AppUserId { get; set; }
		//bunun default değeri basvurdu değeri neyse
		public int AdvertisementAppUserStatusId { get; set; }
		public int MilitaryStatusId { get; set; }
		public DateTime? EndDate { get; set; }
		public int WorkExperience { get; set; }
		public string CvPath { get; set; }
	}
}
