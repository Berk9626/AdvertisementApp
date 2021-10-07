using AutoMapper;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Mappings.AutoMapper
{
	public class GenderProfile : Profile
	{
		public GenderProfile()
		{
			CreateMap<Gender, GenderCreateDto>().ReverseMap();
			CreateMap<Gender, GenderListDto>().ReverseMap();
			CreateMap<Gender, GenderUpdateDto>().ReverseMap();

		}
	}
}
