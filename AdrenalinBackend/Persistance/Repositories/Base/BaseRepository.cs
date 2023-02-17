using Domain.Interfaces;
using Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Persistance.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> 
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected TContext context;
        protected BaseRepository(TContext context)
        {
            this.context = context;
        }

        public async Task<List<TEntity>> AllIncludingAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> FindAllByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity?> GetSingleAsync(string id)
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<TEntity?> GetSingleByPropertyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<TEntity?> GetSingleIncludingAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            foreach(var includeProperty in includeProperties)
            {
                query.Include(includeProperty);
            }

            return await query.Where(predicate).FirstOrDefaultAsync();
        }
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            return entity;
        }

        public virtual async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return entity;

            //    EntityEntry dbEntityEntry = context.Entry(entity);
            //    dbEntityEntry.State = EntityState.Modified;
        }

        public virtual async Task<TEntity?> DeleteAsync(string id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);

            if (entity == null) return entity;

            context.Set<TEntity>().Remove(entity);
            return entity;

            //EntityEntry dbEntityEntry = context.Entry(entity);
            //dbEntityEntry.State = EntityState.Deleted;
        }
    }
}
