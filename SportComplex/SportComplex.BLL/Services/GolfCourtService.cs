using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class GolfCourtService : GenericService<GolfCourtModel, GolfCourtEntity>, IGolfCourtService
    {
        public GolfCourtService(IGolfCourtRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
