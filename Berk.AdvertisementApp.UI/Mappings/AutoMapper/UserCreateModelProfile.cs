using AutoMapper;
using Berk.AdvertisementApp.Dtos;
using Berk.AdvertisementApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Mappings.AutoMapper
{
	public class UserCreateModelProfile :Profile
	{
		public UserCreateModelProfile()
		{
			CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
		}
	}
}
