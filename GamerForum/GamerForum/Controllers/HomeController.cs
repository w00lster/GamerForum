using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
 
            return View();
        }

        public ActionResult FrontpageLoggedin()
        {
            return View();
        }

        public ActionResult BoardGames()
        {
            return View();
        }

        public ActionResult Recommendations()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}