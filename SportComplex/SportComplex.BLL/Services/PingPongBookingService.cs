using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class PingPongBookingService : GenericService<PingPongBookingModel, PingPongBookingEntity>, IPingPongBookingService
    {
        public PingPongBookingService(IPingPongBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
