using GamerForum.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GamerForum.Controllers
{
    public class HomeController : Controller
    {
        private static GamerForumContext db = new GamerForumContext();

        public static List<Games> games = db.Games.ToList();

        [AllowAnonymous]
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated) {
                return View(games);
            }
            else
                return RedirectToAction("FrontpageLoggedin");
        }

        public ActionResult FrontpageLoggedin()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
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

        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}