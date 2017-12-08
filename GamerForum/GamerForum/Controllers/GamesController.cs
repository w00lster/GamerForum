using GamerForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerForum.Controllers
{
    public class GamesController : Controller
    {
        private GamerForumContext db = new GamerForumContext();
        // GET: Games
        public ActionResult Index()
        {
            var games = db.Games.ToList();
            return View(games);
        }

        public ActionResult SpecificGame(int id = 0)
        {
            var gameFound = db.Games.FirstOrDefault(g => g.GameId == id);
            gameFound.Images = db.Images.Where(i => i.GameId == gameFound.GameId).ToArray();
            return View(gameFound);
        }

        public ActionResult RequestGameForm()
        {
            return View();
        }
    }
}