using e_commerce.Models;
using System.Collections.Generic;

namespace e_commerce.Data.ViewModels
{
    public class NewMovieDropdownMV
    {

        public NewMovieDropdownMV() {

            Producers = new List<Producer>();
            Actors = new List<Actor>();
            Cinemas = new List<Cinema>();
        }

        public List<Producer> Producers { get; set; }
        public List<Actor> Actors{ get; set;}

        public List<Cinema> Cinemas{ get; set; }

    }
}
