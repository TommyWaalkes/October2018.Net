using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TaskList.Models;

namespace TaskList.Controllers
{
    public class TaskListController : Controller
    {
        TaskListContext db = new TaskListContext();

        public ActionResult Index()
        {
            List<User> users = db.Users.ToList();
            ViewBag.u = users;
            return View(users);
        }
    }
}