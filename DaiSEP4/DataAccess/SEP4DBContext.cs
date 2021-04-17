using DatabaseSEP4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DaiSEP4.DataAccess
{
    public class SEP4DBContext : DbContext
    {
        public DbSet<DimGarden> DimGarden { get; set; }
        public DbSet<Gardener> Gardeners { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<FactPlantStatus> FactPlantStatuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=qd-server.com\\;database=SEP4DB;user=SA;password=04UhKpMXrcDR");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FactPlantStatus>().HasKey(f => new {f.GardenerID, f.GardenID, f.PlantID});
        }
    }
}