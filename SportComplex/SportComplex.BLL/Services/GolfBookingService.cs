using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class GolfBookingService : GenericService<GolfBookingModel, GolfBookingEntity>, IGolfBookingService
    {
        public GolfBookingService(IGolfBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
