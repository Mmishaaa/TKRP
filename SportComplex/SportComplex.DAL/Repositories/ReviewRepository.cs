using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;


namespace SportComplex.DAL.Repositories
{
    public class ReviewRepository : GenericRepository<ReviewEntity>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
