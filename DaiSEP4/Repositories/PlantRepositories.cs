using System.Collections.Generic;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Repositories
{
    public class PlantRepositories : IPlantRepositories
    {
        private Sep4DBContext _context;

        public async Task<Plant> CreatePlant(Plant plant)
        {
            await using (_context = new Sep4DBContext())
            {
                await _context.Plant.AddAsync(plant);
                await _context.SaveChangesAsync();
            }

            return plant;
        }

        public async Task<Plant> GetPlant(int id)
        {
            Plant plant = await _context.Plant.FirstAsync(p => p.ID.Equals(id));
            return plant;
        }

        public async Task<IList<Plant>> GetAllPlants()
        {
           IList<Plant> plants = await _context.Plant.ToListAsync();
           return plants;
        }
    }
}