using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.Database
{
    public static class InitializeDB
    {
        public static void Initialize(DatabaseContext context) //Va start la DB avec tout ce qu'on lui a demandé
        {
            context.Database.EnsureCreated();

            if (context.actors.Any())
            {
                return;
            }

            var actors = new ActorDatabase[]
            {
            new ActorDatabase{FirstName = "Virgile", LastName = "Turco", BirthDate = DateTime.Parse("18/04/1996")},
            new ActorDatabase{FirstName = "Jens", LastName = "Van De Steen", BirthDate = DateTime.Parse("05/09/1994")},
            new ActorDatabase{FirstName = "Pierre", LastName = "Chevalier", BirthDate = DateTime.Parse("17/04/2006")},
            new ActorDatabase{FirstName = "Jean", LastName = "Charles", BirthDate = DateTime.Parse("17/04/2015")},
            new ActorDatabase{FirstName = "Nicolas", LastName = "Zawada", BirthDate = DateTime.Parse("17/04/2012")}
            
            };

            foreach(ActorDatabase actor in actors)
            {
                context.actors.Add(actor);
            }

            context.SaveChanges();
        }
    }
}
