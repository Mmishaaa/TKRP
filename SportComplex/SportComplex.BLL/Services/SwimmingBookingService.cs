using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class SwimmingPoolBookingService : GenericService<SwimmingPoolBookingModel, SwimmingPoolBookingEntity>, ISwimmingPoolBookingService
    {
        public SwimmingPoolBookingService(ISwimmingPoolBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
