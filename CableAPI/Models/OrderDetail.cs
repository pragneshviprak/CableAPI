using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CableAPI.Models
{
	public class OrderDetail
	{
		public Guid? OrderId { get; set; }
		public string Unit { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public string Status { get; set; }
		public string AccountNumber { get; set; }
		public string ServiceType { get; set; }
		public string WorkOrderId { get; set; }
		public string Notes { get; set; }

		public string CarrierName { get; set; }
		public int UserId { get; set; }
		public string OrderType { get; set; }
	}
}