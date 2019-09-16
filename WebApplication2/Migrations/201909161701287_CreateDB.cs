namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercise",
                c => new
                    {
                        ExerciseID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ExerciseID);
            
            CreateTable(
                "dbo.TypeWorkout",
                c => new
                    {
                        TypeWorkoutID = c.Int(nullable: false, identity: true),
                        Repetition = c.Int(nullable: false),
                        Serie = c.Int(nullable: false),
                        Pause = c.Single(nullable: false),
                        Description = c.String(),
                        WorkoutID = c.Int(nullable: false),
                        ExerciseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypeWorkoutID)
                .ForeignKey("dbo.Exercise", t => t.ExerciseID, cascadeDelete: true)
                .ForeignKey("dbo.Workout", t => t.WorkoutID, cascadeDelete: true)
                .Index(t => t.WorkoutID)
                .Index(t => t.ExerciseID);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        RecipeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ingredients = c.String(),
                        PreparationMode = c.String(),
                        NutritionalValues = c.String(),
                    })
                .PrimaryKey(t => t.RecipeID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Username = c.String(),
                        Age = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Workout",
                c => new
                    {
                        WorkoutID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.WorkoutID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TypeWorkout", "WorkoutID", "dbo.Workout");
            DropForeignKey("dbo.TypeWorkout", "ExerciseID", "dbo.Exercise");
            DropIndex("dbo.TypeWorkout", new[] { "ExerciseID" });
            DropIndex("dbo.TypeWorkout", new[] { "WorkoutID" });
            DropTable("dbo.Workout");
            DropTable("dbo.User");
            DropTable("dbo.Recipe");
            DropTable("dbo.TypeWorkout");
            DropTable("dbo.Exercise");
        }
    }
}
