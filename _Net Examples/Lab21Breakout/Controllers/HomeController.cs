using Lab21Breakout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21Breakout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.index = "Welcome to my coffee shop";
            return View();
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

        public ActionResult Register()
        {

            return View();
        }

        public ActionResult Result(Registration r)
        {
            ViewBag.name = r.firstName;
            ViewBag.pw = r.password;
            return View(r);
        }
    }
}