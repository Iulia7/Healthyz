using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TypeWorkout> TypeWorkouts  { get; set; }
    }
}