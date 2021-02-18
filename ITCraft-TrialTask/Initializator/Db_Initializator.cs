using ITCraft_TrialTask.Models;
using System;
using System.Linq;

namespace ITCraft_TrialTask.Initializator
{
    public class Db_Initializator
    {
        public static void Initialize(ItCraftDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                context.Users.AddRange(new User {Name = "Denis", Active = false},
                    new User {Name = "Vlad", Active = true},
                    new User {Name = "Dima", Active = false},
                    new User {Name = "Bob", Active = false},
                    new User {Name = "Anton", Active = true},
                    new User {Name = "Alex", Active = false});

                context.SaveChanges();
            }

       

        }
    }
}
