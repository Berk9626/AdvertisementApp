using AutoMapper;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.DataAccess.UnitOfWork;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Services
{ //ProvideServiceService == ProvideService entity sondaki Service onla ilgili işleri yapan classım
	public class ProvideServiceService : Service<ProvideServiceCreateDto,ProvideServiceUpdateDto,ProvideServiceListDto,ProvideService>, IProvideServiceService
	{ //gidip BUSINESTAKİ DEPENDENCY KISMINA !!!! SERVICES ADDSCOPED YAZARAK IPROVIDESERVICE ÇAĞIRDIĞINDA BANA BUNU GETİR !!!
		public ProvideServiceService(IMapper mapper, IValidator<ProvideServiceCreateDto> createDtoValidator,
			IValidator<ProvideServiceUpdateDto> updateDtoValidator, IUow uow)
			:base(mapper,createDtoValidator, updateDtoValidator, uow) //bu basein içine baktığında göndermemiz gereken automapper,validator, uow istiyor bizden. Aslında biz genericServisten bunları henüz kullanmıyoruz.Biz burada belirdikten sonra generic servisteki parametrelere setlenecek ve o zaman uygulancak
		{                                                             //basede örneklerim alınacak sonra constructura tekmeliyoruz.




		}

	}
}
