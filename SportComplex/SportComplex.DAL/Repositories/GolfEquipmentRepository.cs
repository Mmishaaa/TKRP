using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class GolfEquipmentRepository : GenericRepository<GolfEquipmentEntity>, IGolfEquipmentRepository
    {
        public GolfEquipmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
