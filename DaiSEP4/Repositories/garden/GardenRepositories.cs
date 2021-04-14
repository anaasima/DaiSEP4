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
        
        public async Task CreateGarden(DimGarden dimGarden)
        {
            await using (_context = new Sep4DBContext())
            {
                await _context.DimGarden.AddAsync(dimGarden);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DimGarden> GetGardenById(int id)
        {
            DimGarden dimGarden = await _context.DimGarden.FirstAsync(gdn => gdn.Id == id);
            return dimGarden;
        }
        
    }
}