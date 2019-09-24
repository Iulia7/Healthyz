using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class WorkoutController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Exercise
        public ActionResult Index()
        {
            return View(db.Workouts.ToList());
        }

        public ActionResult Details(int? id)
        {

            Workout workout = db.Workouts.Find(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}