using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class SwimmingPoolEquipmentService : GenericService<SwimmingPoolEquipmentModel, SwimmingPoolEquipmentEntity>, ISwimmingPoolEquipmentService
    {
        public SwimmingPoolEquipmentService(ISwimmingPoolEquipmentRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
