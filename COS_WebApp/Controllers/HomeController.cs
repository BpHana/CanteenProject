using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COS_WebApp.Models;


namespace COS_WebApp.Controllers
{
    public class HomeController : Controller
    {
        CanteenOrderingSystemEntities cos = new CanteenOrderingSystemEntities();

        public ActionResult Index()
        {
            var listpro = cos.products.OrderByDescending(x => x.id).ToList();

            listpro.Take(5);

            return View(listpro);
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
    }
}