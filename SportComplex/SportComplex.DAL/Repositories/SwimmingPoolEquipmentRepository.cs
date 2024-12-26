using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class SwimmingPoolEquipmentRepository(ApplicationDbContext context) : GenericRepository<SwimmingPoolEquipmentEntity>(context), ISwimmingPoolEquipmentRepository;
}
