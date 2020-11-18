using COS_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COS_WebApp.Controllers
{
    public class CartController : Controller
    {
        CanteenOrderingSystemEntities cos = new CanteenOrderingSystemEntities();
        List<ShoppingCart> shopCart;
        // GET: Cart
        public ActionResult Cart()
        {

            int userid = (Session["User"] as account).id;
            var cart = cos.carts;
            foreach (var item in cart)
            {
                if (item.id_user == userid)
                {
                    var query = from product in cos.products
                                where product.id == item.id_products
                                select product;
                    product prod = query.FirstOrDefault();
                    ShoppingCart dto = new ShoppingCart(prod, item.quantity);
                    if (shopCart == null)
                    {
                        shopCart = new List<ShoppingCart>();
                    }
                    shopCart.Add(dto);
                }
            }

            return View(shopCart);
        }

        public ActionResult deleteCart(string id)
        {
            int idCart = Convert.ToInt32(id);
            int userid = (Session["User"] as account).id;

            var query = from cart in cos.carts
                        where cart.id_products == idCart && cart.id_user == userid
                        select cart;
            if (query.SingleOrDefault() != null)
            {
                cart obj = query.FirstOrDefault();
                cos.carts.Remove(obj);
                cos.SaveChanges();
            }


            return RedirectToAction("Cart");
        }
        public ActionResult action()
        {
            return RedirectToAction("Cart");

        }

        [HttpGet]
        public ActionResult action(string[] id, string[] quantity, string btnAction)
        {
            switch (btnAction)
            {
                case "Update Cart":
                    updateCart(id, quantity);

                    break;
                case "Order":
                    return RedirectToAction("Order");

            }
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public ActionResult updateCart(string[] id, string[] quantity)
        {


            int userid = (Session["User"] as account).id;
            for (int i = 0; i < id.Length; i++)
            {
                int idCart = Convert.ToInt32(id[i]);
                int quantityP = Convert.ToInt32(quantity[i]);
                var query = from cart in cos.carts
                            where cart.id_products == idCart && cart.id_user == userid
                            select cart;

                cart obj = query.FirstOrDefault();
                obj.quantity = quantityP;

                cos.SaveChanges();


            }


            return RedirectToAction("Cart");
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


            return View("Cart");

        }

        public ActionResult Order()
        {
            int userid = (Session["User"] as account).id;
            var cart = cos.carts;
            foreach (var item in cart)
            {
                if (item.id_user == userid)
                {
                    var query = from product in cos.products
                                where product.id == item.id_products
                                select product;
                    product prod = query.FirstOrDefault();
                    ShoppingCart dto = new ShoppingCart(prod, item.quantity);
                    if (shopCart == null)
                    {
                        shopCart = new List<ShoppingCart>();
                    }
                    shopCart.Add(dto);
                }
            }


            return View(shopCart);
        }

        public ActionResult AddOrder(String address)
        {
            int userid = (Session["User"] as account).id;
            decimal totalprice = 0;
            var cart = cos.carts;
            foreach (var item in cart)
            {
                if (item.id_user == userid)
                {
                    var query = from product in cos.products
                                where product.id == item.id_products
                                select product;
                    product prod = query.FirstOrDefault();
                    totalprice += prod.price * item.quantity;
                    ShoppingCart dto = new ShoppingCart(prod, item.quantity);
                    if (shopCart == null)
                    {
                        shopCart = new List<ShoppingCart>();
                    }
                    shopCart.Add(dto);
                }
            }

            order od = new order { id_user = userid, totalprice = totalprice, createdAt = DateTime.Now, address = address };
            cos.orders.Add(od);
            cos.SaveChanges();

            var query1 = from order in cos.orders
                         where order.id_user == userid
                         select order;

            query1 = query1.OrderByDescending(o => o.id);
            order or = query1.FirstOrDefault();
            foreach (var item in shopCart)
            {
                order_details detail = new order_details { id_order = or.id, id_products = item.Product.id, quantity = item.Quantity, createdAt = or.createdAt };
                cos.order_details.Add(detail);
               

                cos.carts.RemoveRange(cos.carts.Where(x => x.id_user == userid));
                cos.SaveChanges();
            }
            return RedirectToAction("Index", "Home");

        }


        [HttpPost]
        public ActionResult AddToCart(product prod, int Id)
        {
            return View();
        }

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cart/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
