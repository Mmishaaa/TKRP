using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class PingPongBookingRepository : GenericRepository<PingPongBookingEntity>, IPingPongBookingRepository
    {
        public PingPongBookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
