using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Exercise
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult Details(int? id)
        {

           User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}