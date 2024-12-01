using e_commerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAllAsync();
       Task <Actor> GetByIdAsync(int id);

       Task <Actor> UpdateAsync(int id, Actor NewActor);
        Task  DeleteAsync(int id);

        Task AddAsync(Actor actor);

    }
}
