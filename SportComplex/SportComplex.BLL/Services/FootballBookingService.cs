using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class FootballBookingService : GenericService<FootballBookingModel, FootballBookingEntity>, IFootballBookingService
    {
        public FootballBookingService(IFootballBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
