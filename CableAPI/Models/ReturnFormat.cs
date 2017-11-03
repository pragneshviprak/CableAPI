using CableAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace CableAPI.Models
{
	public class ReturnFormat
	{
		public class Reply
		{
			public string status { get; set; }
			public string msg { get; set; }
			public string error { get; set; }
			public dynamic data { get; set; }
		}

		public JsonResult Success(string txt, dynamic data = null)
		{
			return PrepareReply(false, txt, data);
		}

		public JsonResult Error(string txt)
		{
			return PrepareReply(true, txt);
		}

		public JsonResult PrepareReply(bool isError, string txt, dynamic data = null)
		{
			var reply = new Reply
			{
				status = isError ? Message.FAIL : Message.SUCCESS,
				msg = isError ? "" : txt,
				error = isError ? txt : null,
				data = data,
			};
			return new JsonNetResult(reply, JsonRequestBehavior.AllowGet);
		}
	}

	public class Message
	{
		public const string FAIL = "Fail";
		public const string SUCCESS = "Success";
	}

	public class JsonNetResult : JsonResult
	{
		private JsonNetResult()
		{
			this.ContentType = "application/json";
		}

		public JsonNetResult(object data, JsonRequestBehavior jsonRequestBehavior)
		{
			this.ContentEncoding = Encoding.UTF8;
			this.ContentType = "application/json";
			this.Data = data;
			this.JsonRequestBehavior = jsonRequestBehavior;
		}
	}

}
