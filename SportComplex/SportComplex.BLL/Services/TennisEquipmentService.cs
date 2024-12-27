using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class TennisEquipmentService : GenericService<TennisEquipmentModel, TennisEquipmentEntity>, ITennisEquipmentService
    {
        public TennisEquipmentService(ITennisEquipmentRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
