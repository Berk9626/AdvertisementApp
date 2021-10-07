using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Entities
{
	public class Advertisement : BaseEntity
	{ //title = ilanın başlığı(sallıyorum yazılım geliştirme uzmanı), description= açıklaması, status(bit olarak verdim, (açık veya kapalı))= ilanın açık veya kapalı olma durumu, createdDate'de oluşturulma zamanı
		public string Title { get; set; }
		public bool Status { get; set; }
		public string Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public List<AdvertisementAppUser> AdvertisementAppUsers { get; set; }


	}
}
