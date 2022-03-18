using MovieWeb.Database;
using NetFlow.Database.Episode;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Dto.Movie
{
    public class GetMovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }            
        public string Picture { get; set; }
        public string Type { get; set; }
    }
}
