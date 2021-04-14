using System.Threading.Tasks;
using DatabaseSEP4.Models;

namespace DaiSEP4.Repositories
{
    public interface IGardenerRepositories
    {
        Task CreateGardener(Gardener gardener);
        Task<Gardener> GetGardener(int id);
    }
}