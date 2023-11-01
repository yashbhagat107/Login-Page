using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_Page.Models;

namespace Login_Page.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
            public ActionResult Index(MyModel MM)
        {
            string email = MM.Username;
            string Password = MM.Password;
            if (email == "yashbhagat107@gmail.com" && Password == "yash@123")
            {
                return RedirectToAction("Welcome", "Home");
            }
            else
            {
                TempData["Error"] = "<script>alert('Please enter valid Email ID and Password')</script>";

            }
            return View();
        }

        public ActionResult Welcome()
        {
             return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}