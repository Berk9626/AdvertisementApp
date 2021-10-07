using Berk.AdvertisementApp.DataAccess.Contexts;
using Berk.AdvertisementApp.DataAccess.Interfaces;
using Berk.AdvertisementApp.DataAccess.Repositories;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.DataAccess.UnitOfWork
{//ilgili repository'leri tek bir contextin ilgili requeste gittiğinden emin olmak
	public class Uow :IUow
	{
		private readonly AdvertisementContext _context;

		public Uow(AdvertisementContext context)
		{
			_context = context;
		}

		public IRepository<T> GetRepository<T>() where T: BaseEntity
		{
			return new Repository<T>(_context);
		}
		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
