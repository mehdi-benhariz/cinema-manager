using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Cinema


    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name = "Logo ")]

        public string Logo { get; set; }

        [Display(Name = "Name ")]

        public string Name { get; set; }
        [Display(Name = "Description ")]


        public string Description { get; set; }
        //RelationShips
        public List<Movie> Movies;
    }
}
