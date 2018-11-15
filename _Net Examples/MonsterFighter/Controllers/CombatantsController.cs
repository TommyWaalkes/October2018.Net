using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonsterFighter.Models;

namespace MonsterFighter.Controllers
{
    public class CombatantsController : Controller
    {
        private CombatantContext db = new CombatantContext();

        // GET: Combatants
        public ActionResult Index()
        {
            return View(db.Combatants.ToList());
        }

        // GET: Combatants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combatant combatant = db.Combatants.Find(id);
            if (combatant == null)
            {
                return HttpNotFound();
            }
            return View(combatant);
        }

        // GET: Combatants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Combatants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Hp,Attack")] Combatant combatant)
        {
            if (ModelState.IsValid)
            {
                db.Combatants.Add(combatant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combatant);
        }

        // GET: Combatants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combatant combatant = db.Combatants.Find(id);
            if (combatant == null)
            {
                return HttpNotFound();
            }
            return View(combatant);
        }

        // POST: Combatants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Hp,Attack")] Combatant combatant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combatant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combatant);
        }

        // GET: Combatants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combatant combatant = db.Combatants.Find(id);
            if (combatant == null)
            {
                return HttpNotFound();
            }
            return View(combatant);
        }

        // POST: Combatants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Combatant combatant = db.Combatants.Find(id);
            db.Combatants.Remove(combatant);
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

        public ActionResult PickFighter()
        {
            List<Combatant> cs = db.Combatants.ToList();
            ViewBag.Combatants = cs;
            Session["FirstRun"] = true;
            return View();
        }

        public ActionResult Fight(int ID1, int ID2)
        {
            //Session["Fighter1"] == null || Session["Fighter2"] == null
            //Initial Setup
            if ((bool) Session["FirstRun"])
            {
                if (Session["Fighter1"] == null)
                {
                    Combatant c1 = db.Combatants.Find(ID1);
                    Session["Fighter1"] = c1;
                }

                if (Session["Fighter2"] == null)
                {
                    Combatant c2 = db.Combatants.Find(ID2);
                    Session["Fighter2"] = c2;
                }
                Session["FirstRun"] = false;
            }
            else
            {
                //Do fight
                Combatant p1 = (Combatant)Session["Fighter1"];
                Combatant p2 = (Combatant)Session["Fighter2"];

                p1.AttackEnemy(p2);
                p2.AttackEnemy(p1);

                if (p1.IsDead())
                {
                    Session["WinnerName"] = p2.Name;
                    return RedirectToAction("Result");
                }
                else if (p2.IsDead())
                {
                    Session["WinnerName"] = p1.Name;
                    return RedirectToAction("Result");
                }
            }


            return View();
        }

        public ActionResult Result()
        {

            return View();
        }
    }
}
