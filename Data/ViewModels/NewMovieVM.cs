using e_commerce.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using e_commerce.Data;

namespace e_commerce.Models
{
    public class NewMovieVM
    {


        [Display(Description ="Movie name" )]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Display(Description = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]

        public string Description { get; set; }
        [Display(Description = "Movie Price")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Display(Description = "Movie ImageUrl")]
        [Required(ErrorMessage = "Image is Required")]
        public string ImageURL { get; set; }
        [Display(Description = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime StartDate { get; set; }
        [Display(Description = "Movie EndDate")]
        [Required(ErrorMessage = "End Date is Required")]
        public DateTime EndDate { get; set; }
        [Display(Description = "Select a Movie Category")]
        [Required(ErrorMessage = "Movie Category is Required")]

        public MovieCategory MovieCategory { get; set; }

        //Relationship
        [Display(Description = "Movie Actors")]
        [Required(ErrorMessage = "Movie should have actors")]
        public List<int> ActorIds { get; set; }

        [Display(Description = "Movie Cinema")]
        [Required(ErrorMessage = "Cinema is Required")]
        public int CinemaId { get; set; }
        [Display(Description = "Movie Producer")]
        [Required(ErrorMessage = "Producer is Required")]
        public int ProducerId { get; set; }
      



    }
}
