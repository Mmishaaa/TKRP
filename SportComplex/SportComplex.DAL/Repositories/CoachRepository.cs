using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class CoachRepository : GenericRepository<CoachEntity>, ICoachRepository
    {
        public CoachRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
