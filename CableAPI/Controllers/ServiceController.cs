using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CableAPI.Data;
using CableAPI.Models;

namespace CableAPI.Controllers
{
	public class ServiceController : Controller
	{
		TimeWarnerEntities _context = new TimeWarnerEntities();
		// GET: Service

		//[HttpGet]
		//public JsonResult Index(string UserName, string Password)
		//{
		//	//UserName = "admin@4tpp.com";
		//	//Password = "test123";
		//	var UserData = _context.p_VerifyUser(UserName, Password).ToList();
		//	return new ReturnFormat().Success(Message.SUCCESS, UserData);

		//}

		[HttpGet]
		public JsonResult VerifyUser(string UserName, string Password)
		{
			try
			{
				var UserData = _context.p_VerifyUser(UserName, Password).ToList();
				return new ReturnFormat().Success(Message.SUCCESS, UserData);
			}
			catch (Exception ex)
			{
				return new ReturnFormat().Error(ex.Message.ToString());
			}
		}

		[HttpPost]
		public JsonResult InsertOrder(OrderDetail _Order)
		{
			try
			{
				_Order.OrderId = Guid.NewGuid();
				var OrderId = _context.p_InsertOrder(_Order.OrderId,_Order.Unit, _Order.StreetAddress, _Order.City, _Order.State, _Order.ZipCode, _Order.FirstName, _Order.LastName, _Order.Email, _Order.Phone).FirstOrDefault();
				return new ReturnFormat().Success(Message.SUCCESS, OrderId);
			}
			catch(Exception ex)
			{
				return new ReturnFormat().Error(ex.Message.ToString());
			}
		}
	}
}

