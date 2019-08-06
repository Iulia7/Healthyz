using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TypeWorkout
    {
        public int TypeWorkoutID { get; set; }
        public int Repetition { get; set; }
        public int Serie { get; set; }
        public float Pause { get; set; }
        public string Description { get; set; }

        public virtual int WorkoutID { get; set; }
        public virtual int ExerciseID { get; set; }
    }
}