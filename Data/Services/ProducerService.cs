using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public class ProducerService : IProducersService
    {
        private readonly AppDbcontext _context;

        public ProducerService(AppDbcontext context)
        {
            _context = context;
        }


        public async Task AddAsync(Producer producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.ProducerId == id);
            _context.Producers.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producer>> getAllAsync()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        } 

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.ProducerId == id);
            return result;
        }

        public async Task<Producer> UpdateAsync(int id, Producer NewProducer)
        {
            _context.Update(NewProducer);
            await _context.SaveChangesAsync();
            return NewProducer;
        }

       
    }
}
