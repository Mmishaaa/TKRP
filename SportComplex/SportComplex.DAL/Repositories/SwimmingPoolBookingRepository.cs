using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class SwimmingPoolBookingRepository(ApplicationDbContext context) : GenericRepository<SwimmingPoolBookingEntity>(context), ISwimmingPoolBookingRepository;
}
