using e_commerce.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Display(Name = "Name ")]

        public string Name { get; set; }
        [Display(Name = "Description ")]


        public string Description { get; set; }
        [Display(Name = "Price ")]

        public double Price { get; set; }
        [Display(Name = "ImageURL ")]

        public string ImageURL { get; set; }
        [Display(Name = "Start Date ")]

        public DateTime StartDate { get; set; }
        [Display(Name = "End date ")]

        public DateTime EndDate { get; set; }
        [Display(Name = "MovieCategory ")]


        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movie { get; set; }

        //Cinema

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }
        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }





    }
}
