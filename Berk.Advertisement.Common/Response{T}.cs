using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berk.Advertisement.Common
{//data taşıyan response
	public class Response<T> : Response, IResponse<T>
	{
		public T Data { get; set; }
		public List<CustomValidationError> ValidationErrors { get; set; }

		public Response(ResponseType responseType, string message) : base(responseType, message)
		{//not found

		}
		public Response(ResponseType responseType, T data): base(responseType)
		{//success
			Data = data;
		}
		public Response(T data, List<CustomValidationError> errors): base(ResponseType.ValidationError)
		{//error
			ValidationErrors = errors;
			Data = data;

		}
	}
}
