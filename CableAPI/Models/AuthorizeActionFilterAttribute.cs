using CableAPI.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CableAPI.Models
{
	public class AuthorizeActionFilterAttribute : AuthorizeAttribute
	{
		TimeWarnerEntities _context = new TimeWarnerEntities();
		public AuthorizeActionFilterAttribute()
		{

		}
		public override void OnAuthorization(AuthorizationContext filterContext)
		{
			if (!filterContext.ActionDescriptor.IsDefined
					   (typeof(AllowAnonymousAttribute), true))
			{
				bool Status = false;
				var Token = ConfigurationManager.AppSettings["SecurityToken"];
				Status = _context.SecurityTokens.Where(c => c.Token.ToString() == Token).Count() > 0 ? true : false;

				if (!Status)
				{
					filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Service" }, { "action", "NotAuthorized" } });
				}
			}
		}
	}
}