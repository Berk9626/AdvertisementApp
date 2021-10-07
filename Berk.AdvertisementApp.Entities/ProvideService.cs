using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Entities
{
	public class ProvideService : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
