using NetFlow.Database.Episode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.Database.Movie
{
    public class MovieDatabase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ActorDatabase> Actors { get; set; }
        public List<EpisodeDatabase> Episodes { get; set; }
        public string Picture { get; set; }
        public string Type { get; set; }
        
        
    }
}
