using Berk.Advertisement.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.AdvertisementApp.UI.Extensions
{
	public static  class ControllerExtensions //controllerı extens edeceğim, genişletmeye çalışıyorum.
	{
		public static IActionResult ResponseRedirectAction<T>(this Controller controller, IResponse<T> response, string actionName, string controllerName="")
		{

			if (response.ResponseType == ResponseType.NotFound)
			{
				return controller.NotFound();
			}

			if (response.ResponseType == ResponseType.ValidationError)
			{
				foreach (var error in response.ValidationErrors)
				{
					controller.ModelState.AddModelError(error.PropertyName, error.Message);
				}
				return controller.View(response.Data);
			}

				if (string.IsNullOrWhiteSpace(controllerName))
				{
					return controller.RedirectToAction(actionName);
				}
				else
				{
				return controller.RedirectToAction(actionName, controllerName); //
				}

			
			
		}
		//başka bir tanesinde ise getdatayı getirme durumunda redirect olmuyorum. Aslında bir viewe gidiyorum.
		public static IActionResult ResponseView<T>(this Controller controller, IResponse<T> response)
		{
			if (response.ResponseType == ResponseType.NotFound)
				return controller.NotFound();
			return controller.View(response.Data);
		}

		//public static IActionResult ResponseRedirectAction<T>(this Controller controller, IResponse<T> response, string actionName) yukardaki silme işleminde bir silme datası taşımadığımız için T opsiyonunu taşımayanı yani Generic olmayanını yazıyorduk
		public static IActionResult ResponseRedirectAction(this Controller controller, IResponse response, string actionName)
		{
			if (response.ResponseType == ResponseType.NotFound)
				return controller.NotFound();
			return controller.RedirectToAction(actionName);	
		}




	}
}
