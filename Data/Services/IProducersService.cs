using e_commerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_commerce.Data.Services
{
    public interface IProducersService
    {

        Task<IEnumerable<Producer>> getAllAsync();
        Task<Producer> GetByIdAsync(int id);

        Task<Producer> UpdateAsync(int id, Producer NewProducer);
        Task DeleteAsync(int id);

        Task AddAsync(Producer producer);
    }
}
