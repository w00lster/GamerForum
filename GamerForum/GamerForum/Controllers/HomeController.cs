using GamerForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerForum.Controllers
{
    public class HomeController : Controller
    {
        private GamerForumContext db = new GamerForumContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var games = db.Games.ToList();
            if (User.Identity.IsAuthenticated)
            {
                return View(games);
            }
            else
                return View("~/Views/Home/FrontpageLoggedin.cshtml");
        }
        public ActionResult FrontpageLoggedin()
        {
            var games = db.Games.ToList();
            if (User.Identity.IsAuthenticated)
            {
                return View(games);
            }
            else
                return View(games);
                    
        }

        [AllowAnonymous]
        public ActionResult BoardGames()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Recommendations()
        {
            return View();
        }

        [AllowAnonymous]
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