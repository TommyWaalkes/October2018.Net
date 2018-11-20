using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaskList.Models;

namespace TaskList.Controllers
{
    public class UsersController : Controller
    {
        private TaskListContext db = new TaskListContext();
        //private User LoggedInUser = null;
        // GET: Users
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                User u = (User)Session["user"];
                int id = u.ID;
                ViewBag.Name = u.UserName;
                List<Task> tasks = db.Task.ToList();
                List<Task> usersTasks = new List<Task>();
                foreach(Task t in tasks)
                {
                    if(t.UserId == id)
                    {
                        usersTasks.Add(t);
                    }
                }
                return View(usersTasks);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session["User"] = null;
            return RedirectToAction("Login");
        }
        
        public ActionResult TryLogin(string UserName, string Password)
        {
            if(Session["user"] == null)
            {
                List<User> users = db.Users.ToList();

                foreach(User u in users)
                {
                    if (IsValidLogin(UserName, Password, u))
                    {
                        //LoggedInUser = u;
                        Session["User"] = u;
                        return RedirectToAction("Index");
                    }
                }
            }
            return RedirectToAction("Login");
        }

        public bool IsValidLogin(string UserName, string Password, User u)
        {
            if(u.UserName == UserName && u.Password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTask(string Description, DateTime DueDate)
        {
            if (Session["User"] != null)
            {
                User currentUser = (User)Session["User"];
                ViewBag.Name = currentUser.UserName;
                Task t = new Task();
                t.UserId = currentUser.ID;
                t.Description = Description;
                t.Complete = false;
                t.DueDate = DueDate;

                db.Task.Add(t);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return RedirectToAction("login");
            }
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult CreateUser([Bind(Include = "ID,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();

                Session["User"] = user;
                
            }

            return RedirectToAction("Index");
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
