using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseSEP4.Models;

namespace DaiSEP4.Repositories
{
    public interface IPlantRepositories
    {
        Task<Plant> CreatePlant(Plant plant);
        Task<Plant> GetPlant(int id);
        Task<IList<Plant>> GetAllPlants();
    }
}