using e_commerce.Data;
using e_commerce.Models;
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
            
            var AllCinemas =new List<Cinema>
                    {
                        new Cinema { Name = "Cinema 1", Logo = "logo1.png", Description = "Description 1" },
                        new Cinema { Name = "Cinema 2", Logo = "logo2.png", Description = "Description 2" },
                        new Cinema { Name = "Cinema 3", Logo = "logo3.png", Description = "Description 3" }
                    };
            return View(AllCinemas);
        }
    }
}
