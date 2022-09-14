using eLaptops.Models;
using System.Collections.Generic;
namespace eLaptops.Data.Services
{
    public interface ILaptopsService
    {
        Task<IEnumerable<Laptop>> GetAllAsync();
        Task<Laptop> GetByIdAsync(int id);
       
    }
}
