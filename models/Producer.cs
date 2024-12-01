using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Producer 
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name = "Profile Picture ")]
        public string ProfiilePictureURL { get; set; }
        [Display(Name = "Full Name")]

        public string Name { get; set; }
        [Display(Name = "Biography")]

        public string Bio { get; set; }

        //RelationShips
        public List<Movie> Movies;
    }
}
