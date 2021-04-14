using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.DataAccess
{
    public class Sep4DBContext : DbContext
    {
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<Gardener> Gardeners { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<FactPlantStatus> FactPlantStatuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}