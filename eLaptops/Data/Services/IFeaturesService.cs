using eLaptops.Models;
using System.Collections.Generic;

namespace eLaptops.Data.Services
{
    public interface IFeaturesService
    {
        Task<IEnumerable<Features>> GetAllAsync();
        Task<Features> GetByIdAsync(int id);
        Task AddAsync (Features features);
        Task<Features> UpdateAsync(int id, Features newFeatures);
        Task DeleteAsync(int id);

    }
}
