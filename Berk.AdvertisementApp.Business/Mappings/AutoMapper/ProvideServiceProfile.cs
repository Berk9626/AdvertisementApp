using AutoMapper;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Mappings.AutoMapper
{//mapperlar, çevirme
	public class ProvideServiceProfile : Profile
	{
		public ProvideServiceProfile()
		{ //BUNU YAPTIKTAN SONRA HEP !!!!UNUTUYORUM!!!!! MUTLAKA BUSINESSTAKİ DEPENDENCY EXTENSION KISMINA GİT VE OPT İLE MAPPERCONFIGURATIONA TANIMLA !!!!!!
			CreateMap<ProvideServiceCreateDto, ProvideService>().ReverseMap(); //ilkini ikincisine çevir,reversemaple de tersini yapabiliyorduk.
			CreateMap<ProvideServiceListDto, ProvideService>().ReverseMap();
			CreateMap<ProvideServiceUpdateDto, ProvideService>().ReverseMap();

		}
	}
}
