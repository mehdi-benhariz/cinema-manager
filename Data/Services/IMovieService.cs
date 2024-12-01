using e_commerce.Data.ViewModels;
using e_commerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> getAllAsync();
        Task AddAsync(Movie movie);

        Task<NewMovieDropdownMV> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
       
    }
}
