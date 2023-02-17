using Domain.Models.Base;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> AllIncludingAsync(
            params Expression<Func<TEntity,
            object>>[] includeProperties);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetSingleAsync(string id);
        Task<TEntity?> GetSingleByPropertyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> GetSingleIncludingAsync(
          Expression<Func<TEntity, bool>> predicate,
          params Expression<Func<TEntity, object>>[] includeProperties);
        Task<List<TEntity>> FindAllByAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(TEntity entity);
        Task<TEntity?> DeleteAsync(string id);
    }
}
