using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class TennisBookingService : GenericService<TennisBookingModel, TennisBookingEntity>, ITennisBookingService
    {
        public TennisBookingService(ITennisBookingRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
