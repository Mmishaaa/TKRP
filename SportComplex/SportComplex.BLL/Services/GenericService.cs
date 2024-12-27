using AutoMapper;
using SportComplex.BLL.Exceptions;
using SportComplex.BLL.Interfaces;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;
using SportComplex.DAL.PaginationModels;

namespace SportComplex.BLL.Services
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel> 
        where TModel : class 
        where TEntity : BaseEntity
    {
        protected IGenericRepository<TEntity> _repository;
        protected IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<TModel> CreateAsync(TModel model, CancellationToken cancellationToken)
        {
            var modelToCreate = _mapper.Map<TEntity>(model);
            var entity = await _repository.AddAsync(modelToCreate, cancellationToken);
            return _mapper.Map<TModel>(entity);
        }

        public virtual async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(id, cancellationToken);

            if(entity is null)
            {
                return;
            }

            await _repository.DeleteAsync(entity, cancellationToken);
        }

        public virtual Task<PagedResult<TModel>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedEntities = _repository.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<Task<PagedResult<TModel>>>(pagedEntities);
        }

        public virtual async Task<TModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<TModel>(entity);
        }

        public virtual async Task<TModel> UpdateAsync(Guid id, TModel model, CancellationToken cancellationToken)
        {
            _ = await _repository.GetByIdAsync(id, cancellationToken) ?? throw new NotFoundException("Entity with this id doesn't exist"); ;
            var newEntity = _mapper.Map<TEntity>(model);
            newEntity.Id = id;
            await _repository.UpdateAsync(newEntity, cancellationToken);
            return _mapper.Map<TModel>(newEntity);
        }
    }
}
