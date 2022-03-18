using MovieWeb.Database;
using MovieWeb.Database.Movie;

using NetFlow.Database.Episode;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Dto
{
    public class GetActorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public DateTime BirthDate { get; set; }        
        public string Picture { get; set; }
        public string Info { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
    }
}

