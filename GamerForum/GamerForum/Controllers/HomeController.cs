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

        public ActionResult BoardGames()
        {
            ViewBag.Message = "Her kommer brætspilundersiden";

            return View();
        }

        public ActionResult Recommendations()
        {
            ViewBag.Message = "Her en liste over vores anbefalede spil. Den er måske baseret på anbefalinger/wanted games og brugerratings?";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Liste med brugerinformationer her";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Om os og kontakt!";

            return View();
        }
    }
}