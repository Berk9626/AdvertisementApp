﻿using Berk.Advertisement.Common;
using Berk.Advertisement.Common.Enums;
using Berk.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Business.Interfaces
{
	public interface IAdvertisementAppUserService
	{
		Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);
		Task<List<AdvertisementAppUserListDto>> GetList(AdvertisementAppUserStatusType type);
		Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusType type);
	}
}
