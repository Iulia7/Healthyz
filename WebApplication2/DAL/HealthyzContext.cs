using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication2.DAL
{
    public class HealthyzContext :DbContext
    {
        public HealthyzContext() : base("HealthyzContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<TypeWorkout> TypeWorkouts { get; set; }
        public DbSet<Forum> Forums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}