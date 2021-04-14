using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.DataAccess
{
    public class Sep4DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}