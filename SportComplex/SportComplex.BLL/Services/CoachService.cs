using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class CoachService : GenericService<CoachModel, CoachEntity>, ICoachService
    {
        public CoachService(ICoachRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
