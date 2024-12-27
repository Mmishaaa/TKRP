using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class SwimmingBookingService : GenericService<SwimmingPoolBookingModel, SwimmingPoolBookingEntity>, ISwimmingPoolBookingService
    {
        public SwimmingBookingService(ISwimmingPoolBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
