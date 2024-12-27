using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class TennisCourtRepository(ApplicationDbContext context) : GenericRepository<TennisCourtEntity>(context), ITennisCourtRepository;
}
