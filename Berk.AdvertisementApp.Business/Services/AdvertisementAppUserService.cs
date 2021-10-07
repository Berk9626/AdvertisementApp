using AutoMapper;
using Berk.Advertisement.Common;
using Berk.Advertisement.Common.Enums;
using Berk.AdvertisementApp.Business.Extensions;
using Berk.AdvertisementApp.Business.Interfaces;
using Berk.AdvertisementApp.DataAccess.UnitOfWork;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Services
{//farklı servis için iyi bir örnek
	public class AdvertisementAppUserService : IAdvertisementAppUserService
	{
		private readonly IUow _uow;
		private readonly IValidator<AdvertisementAppUserCreateDto> _createDtoValidator;
		private readonly IMapper _mapper;

		public AdvertisementAppUserService(IUow uow, IValidator<AdvertisementAppUserCreateDto> createDtoValidator, IMapper mapper)
		{
			_uow = uow;
			_createDtoValidator = createDtoValidator;
			_mapper = mapper;
		}
		public async Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto)
		{
			var result  = _createDtoValidator.Validate(dto);
			if (result.IsValid)
			{
				//control daha önce bu arkadaş başvuru yapmış mı yapmamış mı ?
				var control = await _uow.GetRepository<AdvertisementAppUser>().GetByFilterAsync(x => x.AppUserId == dto.AppUserId && x.AdvertisementId == dto.AdvertisementId);
				//Yukardaki null olması lazım, eğer bu null olmazsa sıkıntı var!! Yani daha önce bu ilana başvurmuş demektir.

				if (control == null)
				{
					var createdAdvertisementAppUser = _mapper.Map<AdvertisementAppUser>(dto);
					await _uow.GetRepository<AdvertisementAppUser>().CreateAsync(createdAdvertisementAppUser);
					await _uow.SaveChangesAsync();
					return new Response<AdvertisementAppUserCreateDto>(ResponseType.Success, dto);
				}
				List<CustomValidationError> errors = new List<CustomValidationError>{new CustomValidationError { Message = "Daha önce başvurulan ilana başvurulamaz." ,
				PropertyName = ""}};
				return new Response<AdvertisementAppUserCreateDto>(dto,errors);

			}
			return new Response<AdvertisementAppUserCreateDto>(dto, result.ConvertToCustomValidationError());

		}

		public async Task<List<AdvertisementAppUserListDto>> GetList(AdvertisementAppUserStatusType type)
		{
			var query = _uow.GetRepository<AdvertisementAppUser>().GetQuery(); //IQuar var elimde.
			var list = await query.Include(x => x.Advertisement).Include(x=>x.AdvertisementAppUserStatus).Include(x=>x.MilitaryStatus).Include(x=>x.AppUser).
				ThenInclude(x=>x.Gender).Where(x=>x.AdvertisementAppUserStatusId == (int)type).ToListAsync();//daha hızlı, eager loading. adv. içinden birşey çekecek olsaydım deninqlude derdim.
																					//adv.appuser içerisindeki adv,appuser,adv.app.user.status,mli.status dolu halde geldi

			return _mapper.Map<List<AdvertisementAppUserListDto>>(list);

		}
		public async Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusType type)
		{
			var query = _uow.GetRepository<AdvertisementAppUser>().GetQuery();
			var entity = await query.SingleOrDefaultAsync(x =>x.Id == advertisementAppUserId);
			entity.AdvertisementAppUserStatusId = (int)type;
			await _uow.SaveChangesAsync();
		}

	}
}
