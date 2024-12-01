using e_commerce.Data.ViewModels;
using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbcontext _context;
        private readonly IProducersService _service;

        public MovieService(AppDbcontext context , IProducersService service)
        {
            _context = context;
            _service = service;
        }
        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description, 
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId,

            };

            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.MovieId,
                    ActorId = actorId,

                };
                await _context.Actors_Movies.AddAsync(newActorMovie);
                    
            }
            await _context.SaveChangesAsync();


        }

        public async Task<IEnumerable<Movie>> getAllAsync()
        {
            var result = await _context.Movies.ToListAsync();
            return result;
        }

       


        async Task<NewMovieDropdownMV> IMovieService.GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownMV();
            response.Actors = await _context.Actors.ToListAsync();
            response.Cinemas = await _context.Cinemas.ToListAsync();
            response.Producers = (List<Producer>)await _service.getAllAsync();
            Console.WriteLine(response.Producers);

            return response;
        }
    }
}
