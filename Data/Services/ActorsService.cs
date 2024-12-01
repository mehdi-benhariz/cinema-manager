using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbcontext _context;

        public ActorsService(AppDbcontext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> getAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result =await  _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result;
        }

        public async Task <Actor> UpdateAsync(int id, Actor NewActor)
        {
            _context.Update(NewActor);
            await _context.SaveChangesAsync();
            return NewActor;
        }
    }
}
