using eLaptops.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eLaptops.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;
        public CompanyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCompany = await _context.Company.ToListAsync();
            return View(allCompany);
        }
    }
}
