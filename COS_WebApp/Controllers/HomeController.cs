using System;
using System.Collections.Generic;
using System.Dynamic;
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
            dynamic model = new ExpandoObject();
            model.Product = cos.products;
            model.Product_Type = cos.products_type;

            return View(model);
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

        public ActionResult ShowAll()
        {
            dynamic model = new ExpandoObject();
            model.Product = cos.products;
            model.Product_Type = cos.products_type;

            return View(model);
        }
    }
}