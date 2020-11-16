using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COS_DesktopApp.Utils;
using COS_WebApp.Models;

namespace COS_WebApp.Controllers
{
    public class AuthenticationController : Controller
    {

        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        // GET: Authentication/Details/5

        [HttpPost]
        public ActionResult Register(string email, string password, string fullname, string dob, string phone)
        {
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine(dob);
                DateTime date = DateTime.ParseExact(dob, "dd/MM/yyyy", null); ;
                string pass = Utils.GetHash(password);
                CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities();
                

                    db.accounts.Add(new account() { email = email, password =pass , fullname = fullname, birthday = date, phonenumber = phone,id_role=4 });
                    db.SaveChanges();
                
                return RedirectToAction("Login", "Authentication");
            }
            return RedirectToAction("Register", "Authentication");
            
        }
            
           
        
    

        // GET: Authentication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authentication/Create
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

        // GET: Authentication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authentication/Edit/5
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

        // GET: Authentication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authentication/Delete/5
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
