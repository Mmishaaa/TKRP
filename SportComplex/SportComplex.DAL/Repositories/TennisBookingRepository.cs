using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class TennisBookingRepository(ApplicationDbContext context) : GenericRepository<TennisBookingEntity>(context), ITennisBookingRepository;
}
