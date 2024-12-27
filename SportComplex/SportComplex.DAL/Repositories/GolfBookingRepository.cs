using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class GolfBookingRepository : GenericRepository<GolfBookingEntity>, IGolfBookingRepository
    {
        public GolfBookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
