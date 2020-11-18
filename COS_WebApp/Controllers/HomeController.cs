using System;
using System.Dynamic;
using System.Linq;
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

        public ActionResult ShowCate(String id)
        {
            int ID = Convert.ToInt32(id);
            dynamic model = new ExpandoObject();
            var foundproduct = from p in cos.products
                               where p.id_productsType == ID && p.deletedAt == null 
                               select p;
            var typename = from p in cos.products_type
                               where p.id == ID && p.deletedAt == null
                               select p.name;
            model.Product = foundproduct.ToList();
            model.Name = typename.FirstOrDefault();
            model.Product_Type = cos.products_type;
            
            return View(model);
        }

        public ActionResult ViewDetails(int id)
        {
            var foundproduct = from p in cos.products
                               where p.id == id && p.deletedAt == null
                               select p;
            dynamic model = new ExpandoObject();
            model.Product = foundproduct.FirstOrDefault();
            model.Product_Type = cos.products_type;

            return View(model);
        }
    }
}