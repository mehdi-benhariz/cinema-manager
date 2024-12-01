using e_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbcontext _context;

        public CinemasController(AppDbcontext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllCinemas = await  _context.Cinemas.ToListAsync();
            return View(AllCinemas);
        }
    }
}
