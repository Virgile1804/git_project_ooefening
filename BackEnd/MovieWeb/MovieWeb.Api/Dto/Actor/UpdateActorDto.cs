using MovieWeb.Database.Movie;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Dto
{
    public class UpdateActorDto
    {
        [MaxLength(15)]
        [Required]
        [MinLength(1)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        [Required]
        [MinLength(1)]
        public string LastName { get; set; }

        public string Picture { get; set; }
        public string Info { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDate { get; set; }

    }
}





