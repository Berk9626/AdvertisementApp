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
{
	public class GenderService : Service<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender> , IGenderService
	{
		public GenderService(IMapper mapper, IValidator<GenderCreateDto> genderCreateDto, IValidator<GenderUpdateDto> genderUpdateDto,IUow uow) : base(mapper, genderCreateDto, genderUpdateDto, uow)
		{


		}
	}
}
