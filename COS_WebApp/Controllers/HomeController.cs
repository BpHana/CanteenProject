using System;
using System.Dynamic;
using System.Linq;
using System.Web.Mvc;
using COS_WebApp.Models;
using System.Collections.Generic;

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

        public ActionResult AddToCart(string id)
        {


            int accountid = (Session["User"] as account).id;
            int pid = Convert.ToInt32(id);

            var query = from cart in cos.carts
                        where cart.id_user == accountid && cart.id_products == pid
                        select cart;
            if (query.SingleOrDefault() != null)
            {
                cart existCart = query.FirstOrDefault();
                existCart.quantity++;
            }
            else
            {
                var newcart = new cart { id_user = accountid, id_products = pid, quantity = 1, createdAt = DateTime.Now };
                cos.carts.Add(newcart);

            }

            cos.SaveChanges();

            //if (Session["cart"] == null)
            //{
            //    List<ShoppingCart> cart = new List<ShoppingCart>();
            //    ShoppingCart dto = new ShoppingCart(prod, 1);
            //    cart.Add(dto);
            //    Session["cart"] = cart;
            //}
            //else
            //{
            //    List<ShoppingCart> cart = (List<ShoppingCart>)Session["cart"];
            //    foreach (var item in cart)
            //    {
            //        if (item.Product == prod)
            //        {
            //            item.Quantity++;
            //            return View("Cart");
            //        }
            //    }

            //    ShoppingCart dto = new ShoppingCart(prod, 1);
            //    cart.Add(dto);
            //    Session["cart"] = cart;

            //}


            return RedirectToAction("Index");

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

        public ActionResult ShowSingleProduct(string Id)
        {
            int idP = Convert.ToInt32(Id);
            var prod = cos.products.Where(x => x.id == idP).SingleOrDefault();
            return View(prod);
        }

        List<Categories> listCategories;
        public ActionResult Categories(string type)
        {
            foreach ( var item in cos.products)
            {
                string proType = Convert.ToString(item.products_type);
                if ( proType.Equals(type))
                {
                    var query = from product in cos.products
                                where product.products_type == item.products_type
                                select product;
                    product prod = query.FirstOrDefault();
                    Categories dto = new Categories(prod);
                    if ( listCategories == null)
                    {
                        listCategories = new List<Categories>();
                    }
                    listCategories.Add(dto);
                }
            }
            return View(listCategories);
        }
    }
}