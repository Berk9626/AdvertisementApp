using Berk.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Dtos
{
	public class ProvideServiceCreateDto: IDto
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
		

	}
}
