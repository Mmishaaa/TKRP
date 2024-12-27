using SportComplex.DAL.Entities;
using SportComplex.DAL.PaginationModels;

namespace SportComplex.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<PagedResult<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);
    }
}
