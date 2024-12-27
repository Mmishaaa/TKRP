using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class FootballFieldService : GenericService<FootballFieldModel, FootballFieldEntity>, IFootballFieldService
    {
        public FootballFieldService(IFootballFieldRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
