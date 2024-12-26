using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class PingPongTableRepository : GenericRepository<PingPongTableEntity>, IPingPongTableRepository
    {
        public PingPongTableRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
