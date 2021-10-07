using Berk.Advertisement.Common;
using Berk.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Interfaces
{
	public interface IAdvertisementService: IService<AdvertisementCreateDto,AdvertisementUpdateDto,AdvertisementListDto,Entities.Advertisement>
	{//doğrudan ilgili datayı çekiyor, ancak bu ihtiyacımı karşılamıyor. Sadece aktif olanları çekeceğim. O zaman bu Iserviceler dışında gelecek olanlar dışında benim ayrı bir methoda ihtiyacım var

		Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync(); //aktivleri getiren bir methoda ihtiyacım var. Hatırlarsan database'de statusu false olan bir kayıt vardı.




	}
}
