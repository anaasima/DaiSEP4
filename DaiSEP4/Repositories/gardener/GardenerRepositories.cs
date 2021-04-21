using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Repositories
{
    public class GardenerRepositories : IGardenerRepositories
    {
        private SEP4DBContext _context;

        public async Task CreateGardener(Gardener gardener)
        {
            await using (_context = new SEP4DBContext())
            {
                await _context.Gardeners.AddAsync(new Gardener()
                {
                    Age = gardener.Age,
                    IsOwner = gardener.IsOwner,
                    Username = gardener.Username,
                    Sex = gardener.Sex
                });
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Gardener> GetGardener(int id)
        {
            Gardener gardener = await _context.Gardeners.FirstAsync(gdn => gdn.id == id);
            return gardener;
        }
    }
}