using Berk.AdvertisementApp.DataAccess.Interfaces;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.DataAccess.UnitOfWork
{
	public interface IUow
	{
		IRepository<T> GetRepository<T>() where T : BaseEntity;
		Task SaveChangesAsync();
	}
}
