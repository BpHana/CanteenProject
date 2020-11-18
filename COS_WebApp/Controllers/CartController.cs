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
                        where cart.id_products ==idCart && cart.id_user==userid
                        select cart;
            if (query.SingleOrDefault()!=null)
            {
                cart obj = query.FirstOrDefault();
                cos.carts.Remove(obj);
                cos.SaveChanges();
            }
           

            return RedirectToAction("Cart");
        }
        public ActionResult orderOrUpdate(string action,string )
        {
            switch (action)
            {
                case "Update Cart": updateCart()
            }
        }

        public ActionResult updateCart(string id)
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


            return  View("Cart");

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
