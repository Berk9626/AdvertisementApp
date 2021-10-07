using AutoMapper;
using Berk.Advertisement.Common;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.DataAccess.UnitOfWork;
using Berk.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Services
{
	public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Entities.Advertisement>, IAdvertisementService
	{ //IServiceyi implemente etmedi, çünkü aynıları Service'nin içinde var diye.

		private readonly IUow _uow;
		private readonly IMapper _mapper;
		public AdvertisementService(IMapper mapper, IValidator<AdvertisementCreateDto> createDtoValidator, IValidator<AdvertisementUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
		{
			_mapper = mapper;
			_uow = uow;
		}
		public async Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync()
		{   //bu servise ait bir method söz konusu ve aktif olanları çekeceğim. En son eklenen en başta olacak şekilde çekeceğim.
			//buna özgü spesifik bir method olduğu için, IUow'ye gidip GetAll'lardan ilgili spesifik olan methodu çekeceğim.
			//bu Iuow'yi ele almak için  burda yukarda readonly ile bunu tanımlamam lazım


			var data = await _uow.GetRepository<Entities.Advertisement>().GetAllAsync(x=>x.Status, x=>x.CreatedDate, Advertisement.Common.Enums.OrderByType.DESC);
			var dto = _mapper.Map<List<AdvertisementListDto>>(data);
			return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
			//bunları yaptıktan sonra dependencExtensioana gidip ayar çektik
		}
	}
}
