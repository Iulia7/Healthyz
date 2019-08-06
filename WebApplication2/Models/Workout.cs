using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Workout
    {
        public int WorkoutID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TypeWorkout> TypeWorkouts { get; set; }
    }
}