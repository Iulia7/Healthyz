using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ForumController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Exercise
        public ActionResult Index()
        {
            return View(db.Forums.ToList());
        }

        public ActionResult Details(int? id)
        {

           Forum forum = db.Forums.Find(id);
            if (forum == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}