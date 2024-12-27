using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class TennisEquipmentRepository : GenericRepository<TennisEquipmentEntity>, ITennisEquipmentRepository
    {
        public TennisEquipmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
