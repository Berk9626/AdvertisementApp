using AutoMapper;
using Berk.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Mappings.AutoMapper
{
	public class AdvertisementProfile : Profile
	{
		public AdvertisementProfile()
		{
			CreateMap<Entities.Advertisement, AdvertisementListDto>().ReverseMap();
			CreateMap<Entities.Advertisement, AdvertisementCreateDto>().ReverseMap();
			CreateMap<Entities.Advertisement, AdvertisementUpdateDto>().ReverseMap();
			

		}
	}
}
