using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Dto.Movie
{
    public class UpdateMovieDto
    {
        [MaxLength(15)]
        [Required]
        [MinLength(1)]
        public string Name { get; set; }        
        public string Picture { get; set; }
        public string Type { get; set; }

    }
}
