using System.Linq.Expressions;
using UoFExample.DAL.Entities;

namespace UoFExample.DAL.Reposioties.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> GetAsync(Guid id);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}