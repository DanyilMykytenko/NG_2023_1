using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.Reposioties;

public abstract class BaseRepository<TEntity> : IRepository<TEntity>
    where TEntity : BaseEntity
{

    protected readonly DbSet<TEntity> _dbSet;
    protected readonly DataBaseContext _context;

    protected BaseRepository(DataBaseContext context)
    {
        _dbSet = context.Set<TEntity>();
        _context = context;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _dbSet.Where(expression).ToListAsync();
    }

    public async Task<TEntity?> GetAsync(Guid id)
    {
        var result = await _dbSet.FindAsync(id);

        return result;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var result = await _dbSet.AddAsync(entity);

        return result.Entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var result = _dbSet.Update(entity);

        await _context.SaveChangesAsync();
        
        return result.Entity;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}