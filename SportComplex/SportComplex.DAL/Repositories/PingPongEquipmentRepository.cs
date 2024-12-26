using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class PingPongEquipmentRepository : GenericRepository<PingPongEquipmentEntity>, IPingPongEquipmentRepository
    {
        public PingPongEquipmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
