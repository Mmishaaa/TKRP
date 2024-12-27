using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class PingPongEquipmentService : GenericService<PingPongEquipmentModel, PingPongEquipmentEntity>, IPingPongEquipmentService
    {
        public PingPongEquipmentService(IPingPongEquipmentRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
