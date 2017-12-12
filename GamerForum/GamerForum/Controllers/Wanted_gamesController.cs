using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamerForum.Models;

namespace GamerForum.Controllers
{
    public class Wanted_gamesController : Controller
    {
        private GamerForumContext db = new GamerForumContext();

        // GET: Wanted_games
        public ActionResult Index()
        {
            return View(db.Wanted_game.ToList());
        }

        // GET: Wanted_games/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wanted_games wanted_games = db.Wanted_game.Find(id);
            if (wanted_games == null)
            {
                return HttpNotFound();
            }
            return View(wanted_games);
        }

        // GET: Wanted_games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wanted_games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Wanted_Game_Id,Wanted_Game_Name,Wanted_Game_Url")] Wanted_games wanted_games)
        {
            if (ModelState.IsValid)
            {
                db.Wanted_game.Add(wanted_games);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wanted_games);
        }

        // GET: Wanted_games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wanted_games wanted_games = db.Wanted_game.Find(id);
            if (wanted_games == null)
            {
                return HttpNotFound();
            }
            return View(wanted_games);
        }

        // POST: Wanted_games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Wanted_Game_Id,Wanted_Game_Name,Wanted_Game_Url")] Wanted_games wanted_games)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wanted_games).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wanted_games);
        }

        // GET: Wanted_games/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wanted_games wanted_games = db.Wanted_game.Find(id);
            if (wanted_games == null)
            {
                return HttpNotFound();
            }
            return View(wanted_games);
        }

        // POST: Wanted_games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteConfirmed(int id)
        {
            Wanted_games wanted_games = db.Wanted_game.Find(id);
            db.Wanted_game.Remove(wanted_games);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
