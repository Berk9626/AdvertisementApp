using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////public enum SehirPlakalari
//{
//	Ankara = 6, Kocaeli = 41, İzmir = 35, Adana = 1, Hatay = 31
//}

namespace Berk.Advertisement.Common
{
	public class Response : IResponse
	{
		public Response(ResponseType responseType)
		{
			ResponseType = responseType;
		}
		public Response(ResponseType responseType, string message)
		{
			ResponseType = responseType;
			Message = message;
		}
		public string  Message { get; set; }
		public ResponseType ResponseType { get; set; }

	}


	public enum ResponseType 
	{
		Success,
		ValidationError,
		NotFound,
		//Error //kayıt varsa bakacağı, eğer varsa hata döneceğim
	}
}
