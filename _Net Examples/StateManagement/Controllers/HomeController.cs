using StateManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> Dogs = new List<string>();
            Dogs.Add("Sparky");
            Dogs.Add("Muffin");
            Dogs.Add("LuLu");
            ViewData["MyDogs"] = Dogs;

            List<String> Cats = new List<string>();
            Cats.Add("Inky");
            Cats.Add("Tiger");
            Cats.Add("Meowth");

            ViewBag.MyCats = Cats;

            return View();
        }

        public ActionResult About()
        {
            Session["Name"] = "Tommy";


            return View();
        }

        public ActionResult Contact()
        {
            if (Request.Cookies["User"] != null)
            {
                string output;
                if (Request.Cookies["User"]["Name"] != null)
                {
                    output = Request.Cookies["User"]["Name"];
                    ViewBag.Name = output;
                }

                if(Request.Cookies["User"]["Color"] != null)
                {
                    string color = Request.Cookies["User"]["Color"];
                    ViewBag.Color = color;
                }
                else
                {
                    ViewBag.Color = "Color isn't present in my cookie";
                }
                //How would grab out Color? 
                //If we can't call cookies directly in HMTL, how do we pass them along?
            
            }

            return View();
        }

        public ActionResult Cookie()
        {
            //We must go here to init our cookie
            HttpCookie myCookie = new HttpCookie("User");
            myCookie["Name"] = "Joey";
            myCookie["Color"] = "Blue";
            
           myCookie.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(myCookie);
            return View();
        }

        public ActionResult Object()
        {
            Toy t = new Toy("BasketBall",15.5, 2.00,false);

            ViewBag.bball = t;

            return View();
        }

        public ActionResult ToyView()
        {
            Toy t = new Toy("Rocket Ship", 4, 0.99, true);

            return View(t);
        }

        public ActionResult Logout()
        {
            ViewBag.name = Session["Name"];
            Session["Name"] = null;
            
            
            return View();
        }
    }
}