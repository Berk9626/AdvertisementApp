using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Berk.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Berk.AdvertisementApp.DataAccess.Configurations
{
	public class AdvertisementConfiguration : IEntityTypeConfiguration<Berk.AdvertisementApp.Entities.Advertisement>
	{
		public void Configure(EntityTypeBuilder<Berk.AdvertisementApp.Entities.Advertisement> builder)
		{
			builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
			builder.Property(x => x.Description).HasColumnType("ntext").IsRequired();
			builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()"); //default bir değerle ayağa kalkmasını istiyorsam bunu yaptım. Yada entities kısmına gidip Datetime.Now; diyebilirdik



		}
	}
}
