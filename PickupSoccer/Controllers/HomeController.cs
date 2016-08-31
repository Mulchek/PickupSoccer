using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PickupSoccer.Models;

namespace PickupSoccer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to St. Louis Pick Up Soccer";
            
            // Instantiate a DateTime Object yyyy, mm, dd, hh, mm, ss
            DateTime gameTime = new DateTime(2016, 08, 30, 23, 59, 59);
            
            Game game = new Game(gameTime, "Heman Park");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
