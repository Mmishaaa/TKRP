using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class FootballBookingRepository : GenericRepository<FootballBookingEntity>, IFootballBookingRepository
    {
        public FootballBookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
