using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class SwimmingPoolRepository(ApplicationDbContext context) : GenericRepository<SwimmingPoolEntity>(context), ISwimmingPoolRepository;
}
