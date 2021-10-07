using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Entities
{//Id değeri olacak. BaseEntity'den gelecek. Ve find methodunun içinden o Id ile arama işlemi gerçekleştireceğim
	//İlgili Userım bir başvuru yaptı. Rolü Member olan userlar başvuru yapabilecek. Başvuru yaptığı zaman o kişiye iş listesini göstereceğim, bu iş listesinden başvurusunu gerçekleştirecek.
	//Status = ilgili başvurunun durumu. basitçe açık mı kapalı mı. Zaten ben bunu Advetisementte tuttum ama süreçlerden geçeceği için değerlendirildi, başvuruya alındı, onaylandı, red edildi gibi olabilir. Ya da rolü admin olan kişiye onaylatabiliriz ya da red ettirebiliriz. Yani bizim burda bir lookup table'a ihtiyacımız var. Meselaönceki projemdeki Gender tblosu gibi düşün.Erkek, kadın, belirtmek istemiyorum. yani birdaki status alanı için  AdvertUser için bir lookuptable oluşturup o table'da sadece Id ve definition alanım olacak ve bu definition alanında kabul edildi, red edildi, görüşmeye çağrıldı gibi. Durumlarımı bunun içinde tutacağım
	//MilitaryStatus= burda da lookuptable ihtiyacı var. Askerlik durumu tecilli olabilir,muaf olabilir, yapmış olabilir, tecilli de olabilir. Eğer tecilli ise ne zamana kadar tecilli olduğunun datasını tutmamız gerekiyor.MilitaryEndDate diyebiliriz.
	//workExperience = ....
	//cvpath= rolü member kullanıcı başvururken cv yollayacak, bu cv'yi de sunucuma kaydedeceğim ve kaydettikten sonra da, kaydettiğim yolu buraya setleyeceğim.

	public class AdvertisementAppUser : BaseEntity
	{
		public int AdvertisementId { get; set; }
		public Advertisement Advertisement { get; set; }
		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }

		public int AdvertisementAppUserStatusId { get; set; }
		public AdvertisementAppUserStatus AdvertisementAppUserStatus { get; set; }
		public int MilitaryStatusId { get; set; }
		public MilitaryStatus MilitaryStatus { get; set; }
		public DateTime? EndDate { get; set; } //ilgili militarystatusa göre belirlenecek, tecilliyse EndDate'e setleyecektik
		public int WorkExperience { get; set; }
		public string CvPath { get; set; }




	}
}
