using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.Models.Movie
{
    public class MovieCreateViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(15, ErrorMessage = "Maximum of 10 lenght, please")]
        public string Name { get; set; }
    }
}
