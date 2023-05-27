using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.UoF;

public class UnitOfWork : IUnitOfWork
{
    private DataBaseContext _context;
    public IRepositoryFactory RepositoryFactory { get; }
    
    public UnitOfWork(DataBaseContext context, IRepositoryFactory repositoryFactory)
    {
        _context = context;
        RepositoryFactory = repositoryFactory;
    }

    public TRepository GetRepository<TEntity, TRepository>() where TEntity : BaseEntity where TRepository : class
    {
        return RepositoryFactory.Create<TEntity, TRepository>();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}