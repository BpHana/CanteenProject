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
        CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities();
        // GET: Authentication
        public ActionResult Login()
        {
            if (Session["User"]==null)
            {
                return View();
           }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            
            string pass = Utils.GetHash(password);
            using (CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities())
            {
                var query = from account in db.accounts
                            where account.email == email && account.password == pass &&account.deletedAt==null
                            select account;
                account a = query.FirstOrDefault();




                if (query.SingleOrDefault() != null)
                {
                    Session.Add("User",a);
                    return RedirectToAction("Index", "Home");

                }
               TempData["loginFail"] = "User or password is wrong";
                return RedirectToAction("Login", "Authentication");
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        // GET: Authentication/Details/5

        [HttpPost]
        public ActionResult Register(account a)
        {
            if (ModelState.IsValid)
            {
                a.id_role = 2;
                a.password = Utils.GetHash(a.password);
                db.accounts.Add(a);
                db.SaveChanges();
                return RedirectToAction("Login", "Authentication");
            }
            return RedirectToAction("Register", "Authentication");

        }

        public JsonResult checkEmail(string email)
        {

            var query = from account in db.accounts
                        where account.email == email
                        select account;
            bool status;

            if (query.FirstOrDefault() == null)
            {

                status = true;
            }
            else status = false;
            return Json(status, JsonRequestBehavior.AllowGet);

        }


        // GET: Authentication/Create
        public ActionResult ChangeInfor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeInfor(account acc,DateTime dob)
        {
           
            int idAccount = acc.id;
            var query = from account in db.accounts
                        where account.id==idAccount
                        select account;
            account a = query.FirstOrDefault();
            a.phonenumber = acc.phonenumber;
            a.fullname = acc.fullname;
            a.birthday = dob;

            if (Session["User"]!=null)
            {
                Session["User"] = a;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Authentication");
        }
        public ActionResult ChangePass()
        {
            return View();
        }
        
       [HttpPost]
        public ActionResult ChangePass(string password,string oldPassword,string id)
        {
            oldPassword = Utils.GetHash(oldPassword);
            password= Utils.GetHash(password);
            int idAcc = Convert.ToInt32(id);
            if ((Session["User"] as account).password==oldPassword)
            {
                var query = from account in db.accounts
                            where account.id == idAcc
                            select account;
                account a = query.FirstOrDefault();
                a.password = password;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            TempData["oldPass"] = "Old password is wrong";
            return View();
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
