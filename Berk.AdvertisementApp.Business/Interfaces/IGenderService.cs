using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Interfaces
{
	public interface IGenderService :IService<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>
	{

	}
}
