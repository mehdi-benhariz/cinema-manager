using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Actor

    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile Picture ")]
        [Required(ErrorMessage = "Profile Pic is required")]
        public string ProfiilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50 chars")]

        public string Name { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography Name is required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movie { get; set; }


    }
}
