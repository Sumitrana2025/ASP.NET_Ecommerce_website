using eLaptops.Data;
using eLaptops.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eLaptops.Controllers
{
    public class LaptopsController : Controller
    {

        private readonly ILaptopsService _service;
        public LaptopsController(ILaptopsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var laptopsDetails = await _service.GetByIdAsync(id);

            if (laptopsDetails == null) return View("NotFound");
            return View(laptopsDetails);
        }
    }
}
