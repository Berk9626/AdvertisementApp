using Berk.AdvertisementApp.DataAccess.Configurations;
using Berk.AdvertisementApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Berk.AdvertisementApp.DataAccess.Contexts
{
	public class AdvertisementContext: DbContext
	{
		public AdvertisementContext(DbContextOptions<AdvertisementContext> options): base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AdvertisementAppUserConfiguration());
			modelBuilder.ApplyConfiguration(new AdvertisementAppUserStatusConfiguration());
			modelBuilder.ApplyConfiguration(new AdvertisementConfiguration());
			modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
			modelBuilder.ApplyConfiguration(new AppUserConfiguration());
			modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
			modelBuilder.ApplyConfiguration(new GenderConfiguration());
			modelBuilder.ApplyConfiguration(new MilitaryStatusConfiguration());
			modelBuilder.ApplyConfiguration(new ProvideServiceConfiguration());
		}

		public DbSet<Berk.AdvertisementApp.Entities.Advertisement> Advertisements { get; set; }
		public DbSet<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
		public DbSet<AdvertisementAppUserStatus> AdvertisementAppUserStatuses { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserRole> AppUserRoles { get; set; }
		public DbSet<Gender> Genders { get; set; }
		public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
		public DbSet<ProvideService> ProvideServices { get; set; }
	}
}
