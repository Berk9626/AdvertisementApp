using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.Entities
{ //Generic olarak Find methodum olacak. Dolayısıyla UserRoles bir baseentitity'den kalıtsal yollardan geçmeli. Dolayısıyla bunun da ayrı bir Id değeri olmalı.UserıD VE rOLEId unique olmalı. Aynı şey AdvertisementUser için de geçerli. AdvertisementUser ile User tablosu arasında çoğa çok ilişkiyi sağlayan  tabloda da  yine aynı olayın gerçekleşmesi gerekiyor. Bu yüzden UserRole tablosundaki değerler ve AdvUser tablosundaki değerler tekrar etmeyecek.
	public class BaseEntity
	{
		public int Id { get; set; } //bütün entitylerimde olacak
	}
}
