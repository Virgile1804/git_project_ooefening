using MovieWeb.Database.Movie;
using System;
using System.Collections.Generic;

namespace MovieWeb.Database
{
    public class ActorDatabase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<MovieDatabase> Movies { get; set; }
        public string Picture { get; set; }
        public string Info { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
    }
}
