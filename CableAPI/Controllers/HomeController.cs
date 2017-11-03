using CableAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CableAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		//public ActionResult NotAuthorized()
		//{
		//	return new ReturnFormat().Error("You are not Authorized to access.");
		//}
	}

}
