using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TypeWorkoutController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Recipe
        public ActionResult Index()
        {
            return View(db.TypeWorkouts.ToList());
        }

        public ActionResult Details(int? id)
        {

            TypeWorkout typeworkout = db.TypeWorkouts.Find(id);
            if (typeworkout == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}