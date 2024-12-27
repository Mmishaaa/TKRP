using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class SwimmingPoolService : GenericService<SwimmingPoolModel, SwimmingPoolEntity>, ISwimmingPoolService
    {
        public SwimmingPoolService(ISwimmingPoolRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
