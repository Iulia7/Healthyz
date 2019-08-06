using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class HealthyzInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<HealthyzContext>
    {
        protected override void Seed(HealthyzContext context)
        {
            var users = new List<User>
            {
            new User{UserID=0,Password="1234",Username="user1",Age=16, Adress="Str.21 Decembrie"},
            new User{UserID=1,Password="4321",Username="user2",Age=17, Adress="Str.20 Decembrie"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
}