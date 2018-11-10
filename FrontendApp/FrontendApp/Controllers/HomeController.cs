using EasyNetQ;
using messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontendApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public void Publish(string param)
		{
			using (var bus = RabbitHutch.CreateBus("host=localhost"))
			{
				bus.Publish(new TextMessage
				{
					Text = param
				});
			}
		}
	}
}