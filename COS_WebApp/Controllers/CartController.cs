using COS_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COS_WebApp.Controllers
{
    public class CartController : Controller
    {
        CanteenOrderingSystemEntities cos = new CanteenOrderingSystemEntities();
        // GET: Cart
        public ActionResult Cart()
        {
            return View();
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
            } else
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
