using MovieWeb.Database.Movie;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.Models
{
    public class ActorCreateViewModel
    {
        [Required(AllowEmptyStrings =false)]
        [MaxLength(15, ErrorMessage ="Maximum of 10 lenght, please")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(15, ErrorMessage = "Maximum of 10 lenght, please")]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }       
        public string Picture { get; set; }
        public string Info { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
    }
}
