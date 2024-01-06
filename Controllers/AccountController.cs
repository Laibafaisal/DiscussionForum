using Debatron_v8._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Debatron_v8._0.Controllers
{
    public class AccountController : Controller
    {
        private Entities db = new Entities();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user obj)
        {
            return View();
        }
    

    [HttpGet]
    public ActionResult SignUp()
    {
            /*user obj = new user();
            var data = db.users.OrderByDescending(x => x.User_ID).FirstOrDefault()?.User_ID;
            data += 1;
            ViewBag.Data = data;
           //obj.User_ID = data;*/
            return View();
    }

    [HttpPost]
    public ActionResult SignUp(user obj)
    {
            using (var db1 = new Entities())
            {

                db1.users.Add(obj);
                db1.SaveChanges();
            }
        return RedirectToAction("Index","Home");
    }
}
}