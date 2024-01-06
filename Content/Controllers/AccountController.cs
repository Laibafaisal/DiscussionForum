using Debatron_v9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Debatron_v9.Controllers
{
    public class AccountController : Controller
    {
        private DebatronContext _context = new DebatronContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Member obj)
        {
            bool isValid = _context.users.Any(x => x.UserName == obj.UserName && x.Password == obj.Password);
            if (isValid)
            {
                FormsAuthentication.SetAuthCookie(obj.UserName, true);
                return RedirectToAction("Index","posts");
            }
            ModelState.AddModelError("", "Invalid username or password.");
            return View();
        }


        [HttpGet]
        public ActionResult SignUp()
        { 
            var data = _context.users.OrderByDescending(x => x.User_ID).FirstOrDefault()?.User_ID;
            data += 1;
            ViewBag.Data = data;
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(user obj)
        {
            _context.users.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index", "posts");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}