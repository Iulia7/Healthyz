using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ExerciseController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Exercise
        public ActionResult Index()
        {
            return View(db.Exercises.ToList());
        }

        public ActionResult Details(int? id)
        {

           Exercise exercise = db.Exercises.Find(id);
            if (exercise == null)
            {
                return HttpNotFound();
            }
            return View();
        }
    }
}