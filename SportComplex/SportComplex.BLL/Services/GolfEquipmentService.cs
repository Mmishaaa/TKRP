using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class GolfEquipmentService : GenericService<GolfEquipmentModel, GolfEquipmentEntity>, IGolfEquipmentService
    {
        public GolfEquipmentService(IGolfEquipmentRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
