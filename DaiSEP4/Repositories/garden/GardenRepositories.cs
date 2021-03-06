using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Repositories
{
    public class GardenRepositories : IGardenRepositories
    {
        private SEP4DBContext _context;

        public async Task CreateGarden(DimGarden dimGarden)
        {
            await using (_context = new SEP4DBContext())
            {
                await _context.DimGarden.AddAsync(new DimGarden
                {
                    City = dimGarden.City,
                    LandArea = dimGarden.LandArea,
                    Name = dimGarden.Name,
                    Street = dimGarden.Street,
                    Number = dimGarden.Number
                });
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DimGarden> GetGardenById(int id)
        {
            DimGarden dimGarden = await _context.DimGarden.FirstAsync(gdn => gdn.Garden_ID == id);
            return dimGarden;
        }
    }
}