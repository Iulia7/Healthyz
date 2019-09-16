using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RecipeController : Controller
    {
        private HealthyzContext db = new HealthyzContext();

        // GET: Recipe
        public ActionResult Index()
        {
            return View(db.Recipes.ToList());
        }

        public ActionResult Details(int? id)
        {

            Recipe recipe = db.Recipes.Find(id);
            if (recipe== null)
            {
                return HttpNotFound();
            }
            return View(); 
        }
    }
}