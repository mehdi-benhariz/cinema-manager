using e_commerce.Data;
using e_commerce.Data.Services;
using e_commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class MoviesController : Controller

    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var AllMovies = await _service.getAllAsync();
            return View(AllMovies);
        }
        public async Task<IActionResult> Create() {
            var movieDropdowndata = await _service.GetNewMovieDropdownsValues();

            ViewBag.CinemaId = new SelectList(movieDropdowndata.Cinemas, "CinemaId", "Name");
            ViewBag.ProducerId = new SelectList(movieDropdowndata.Producers, "ProducerId", "FullName");
            ViewBag.ActorId = new SelectList(movieDropdowndata.Actors, "ActorId", "Full Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create (NewMovieVM movie)
        {
            if (!ModelState.IsValid)
             
            {
                var movieDropdowndata = await _service.GetNewMovieDropdownsValues();

                ViewBag.CinemaId = new SelectList(movieDropdowndata.Cinemas, "CinemaId", "Name");
                ViewBag.ProducerId = new SelectList(movieDropdowndata.Producers, "ProducerId", "FullName");
                ViewBag.ActorId = new SelectList(movieDropdowndata.Actors, "ActorId", "Full Name");
                return View(movie);
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

          
    }
}
