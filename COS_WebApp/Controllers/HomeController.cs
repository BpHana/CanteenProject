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

        public ActionResult AddToCart(int Id)
        {
            var prod = cos.products.Where(x => x.id == Id).SingleOrDefault();

            if (Session["cart"] == null)
            {
                List<ShoppingCart> cart = new List<ShoppingCart>();
                ShoppingCart dto = new ShoppingCart(prod, 1);
                cart.Add(dto);
                Session["cart"] = cart;
            }
            else
            {
                List<ShoppingCart> cart = (List<ShoppingCart>)Session["cart"];
                foreach (var item in cart)
                {
                    if (item.Product == prod)
                    {
                        item.Quantity++;
                        return View("Cart");
                    }
                }

                ShoppingCart dto = new ShoppingCart(prod, 1);
                cart.Add(dto);
                Session["cart"] = cart;

            }


            return View("Cart");

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