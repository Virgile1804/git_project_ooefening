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
    }
}
