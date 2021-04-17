using System.Collections.Generic;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Repositories
{
    public class PlantRepositories : IPlantRepositories
    {
        private SEP4DBContext _context;

        public async Task<Plant> CreatePlant(Plant plant)
        {
            await using (_context = new SEP4DBContext())
            {
                await _context.Plants.AddAsync(plant);
                await _context.SaveChangesAsync();
            }

            return plant;
        }

        public async Task<Plant> GetPlant(int id)
        {
            Plant plant = await _context.Plants.FirstAsync(p => p.ID.Equals(id));
            return plant;
        }

        public async Task<IList<Plant>> GetAllPlants()
        {
           IList<Plant> plants = await _context.Plants.ToListAsync();
           return plants;
        }
    }
}