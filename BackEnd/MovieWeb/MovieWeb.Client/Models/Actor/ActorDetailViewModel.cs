using MovieWeb.Database.Movie;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.Models
{
    public class ActorDetailViewModel
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
