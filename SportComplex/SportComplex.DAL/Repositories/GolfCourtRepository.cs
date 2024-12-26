using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class GolfCourtRepository : GenericRepository<GolfCourtEntity>, IGolfCourtRepository
    {
        public GolfCourtRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
