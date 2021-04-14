using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseSEP4.Models;

namespace DaiSEP4.Repositories
{
    public interface IGardenRepositories
    {
        Task CreateGarden(DimGarden dimGarden);
        Task<DimGarden> GetGardenById(int id);
    }
}