using eLaptops.Models;
using Microsoft.EntityFrameworkCore;

namespace eLaptops.Data.Services
{
    public class LaptopsService : ILaptopsService
    {
        private readonly AppDbContext _context;
        public LaptopsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Laptop>> GetAllAsync()
        {
            var result = await _context.Laptops.ToListAsync();
            return result;
        }

        public async Task<Laptop> GetByIdAsync(int id)
        {
            var result = await _context.Laptops.FirstOrDefaultAsync(n => n.LaptopID == id);
            return result;
        }
    }
}
