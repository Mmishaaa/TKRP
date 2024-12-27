using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class ReviewService : GenericService<ReviewModel, ReviewEntity>, IReviewService
    {
        public ReviewService(IReviewRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}