using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string PreparationMode { get; set; }
        public string NutritionalValues { get; set; }
    }
}