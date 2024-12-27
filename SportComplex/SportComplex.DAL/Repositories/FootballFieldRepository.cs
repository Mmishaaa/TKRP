using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class FootballFieldRepository : GenericRepository<FootballFieldEntity>, IFootballFieldRepository
    {
        public FootballFieldRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
