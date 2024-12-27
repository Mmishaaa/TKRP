using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class FootballEquipmentService : GenericService<FootballEquipmentModel, FootballEquipmentEntity>, IFootballEquipmentService
    {
        public FootballEquipmentService(IFootballEquipmentRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
