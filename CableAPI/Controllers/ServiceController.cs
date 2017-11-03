using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CableAPI.Data;

namespace CableAPI.Controllers
{
	public class ServiceController : Controller
	{
		TimeWarnerEntities _context = new TimeWarnerEntities();
		// GET: Service
		public ActionResult Index(string UserName, string Password)
		{
			UserName = "admin@4tpp.com";
			Password = "test123";
			var UserData = _context.p_VerifyUser(UserName, Password).ToList();
			return View();
		}
	}
}