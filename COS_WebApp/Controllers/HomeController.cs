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

        //public ActionResult SeeDetail(int Id)
        //{
        //    var prod = cos.products.Where(x => x.id == Id).SingleOrDefault();
        //    return SingleProduct(prod);
        //}
        //public ActionResult SingleProduct(COS_WebApp.Models.product prod)
        //{
        //    dynamic model = new ExpandoObject();
        //    model.Product = cos.products;
        //    model.Product_Type = cos.products_type;

        //    return View(prod);
        //}

        public ActionResult ShowSingleProduct(string Id)
        {
            int idP = Convert.ToInt32(Id);
            var prod = cos.products.Where(x => x.id == idP).SingleOrDefault();
            return View(prod);
        }
    }
}