using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.DAL.Repositories
{
    public class FootballEquipmentRepository : GenericRepository<FootballEquipmentEntity>, IFootballEquipmentRepository
    {
        public FootballEquipmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
