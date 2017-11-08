using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CableAPI.Data;
using CableAPI.Models;
using System.Configuration;

namespace CableAPI.Controllers
{
	[AuthorizeActionFilter]
	public class ServiceController : Controller
	{
		TimeWarnerEntities _context = new TimeWarnerEntities();

		[HttpPost]
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
		public JsonResult GetCarrierByZipCode(string zipCode)
		{
			try
			{
				var code = _context.p_GetCarrierByZipCode(zipCode).ToList();
				return new ReturnFormat().Success(Message.SUCCESS, code);
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
				var OrderId = _context.p_InsertOrder(_Order.Unit, _Order.StreetAddress, _Order.City, _Order.State, _Order.ZipCode, _Order.FirstName, _Order.LastName, _Order.Email, _Order.Phone, _Order.Status, _Order.AccountNumber, _Order.ServiceType, _Order.WorkOrderId, _Order.Notes, _Order.CarrierName, _Order.UserId).FirstOrDefault();
				return new ReturnFormat().Success("Record Inserted Successfull.", OrderId);
			}
			catch (Exception ex)
			{
				return new ReturnFormat().Error(ex.Message.ToString());
			}
		}

		[HttpPost]
		public JsonResult UpdateOrder(OrderDetail _Order)
		{
			try
			{
				_context.p_UpdateOrder(_Order.Unit, _Order.StreetAddress, _Order.City, _Order.State, _Order.ZipCode, _Order.FirstName, _Order.LastName, _Order.Email, _Order.Phone, _Order.OrderId, _Order.Status, _Order.AccountNumber, _Order.ServiceType, _Order.WorkOrderId, _Order.Notes, _Order.CarrierName, _Order.UserId);
				return new ReturnFormat().Success("Record Updated.", _Order.OrderId);
			}
			catch (Exception ex)
			{
				return new ReturnFormat().Error(ex.Message.ToString());
			}
		}

		[HttpPost]
		public JsonResult GetOrderList(int UserId, string Status, string CarrierName, DateTime FromDate, DateTime ToDate)
		{
			try
			{
				var OrderData = _context.p_GetOrderList(UserId, Status, CarrierName, FromDate, ToDate).ToList();
				return new ReturnFormat().Success(Message.SUCCESS, OrderData);
			}
			catch (Exception ex)
			{
				return new ReturnFormat().Error(ex.Message.ToString());
			}
		}

		[AllowAnonymous]
		public JsonResult NotAuthorized()
		{
			return new ReturnFormat().Error("You are not Authorized to access.");
		}
	}
}

