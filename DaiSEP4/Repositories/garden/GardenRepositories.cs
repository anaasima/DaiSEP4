using System.Collections.Generic;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Repositories
{
    public class GardenRepositories : IGardenRepositories
    {
        private Sep4DBContext _context;
        
        public async Task CreateGarden(Garden garden)
        {
            await using (_context = new Sep4DBContext())
            {
                await _context.Gardens.AddAsync(garden);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Garden> GetGardenById(int id)
        {
            Garden garden = await _context.Gardens.FirstAsync(gdn => gdn.Id == id);
            return garden;
        }
        
    }
}