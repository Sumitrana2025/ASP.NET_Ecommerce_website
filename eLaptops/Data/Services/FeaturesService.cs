using eLaptops.Models;
using Microsoft.EntityFrameworkCore;

namespace eLaptops.Data.Services
{
    public class FeaturesService : IFeaturesService
    {
        private readonly AppDbContext _context;
        public FeaturesService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Features features)
        {
            await _context.Features.AddAsync(features);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Features.FirstOrDefaultAsync(n => n.FeatureID == id);
            _context.Features.Remove(result);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Features>> GetAllAsync()
        {
            var result = await _context.Features.ToListAsync();
            return result;
        }

        public async Task<Features> GetByIdAsync(int id)
        {
            var result = await _context.Features.FirstOrDefaultAsync(n => n.FeatureID == id);
            return result;
        }



        public async Task<Features> UpdateAsync(int id, Features newFeatures)
        {
            _context.Update(newFeatures);
            await _context.SaveChangesAsync();
            return newFeatures;
        }
    }
}
