using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.UoF;

public interface IUnitOfWork
{
    IRepositoryFactory RepositoryFactory { get; }

    TRepository GetRepository<TEntity, TRepository>() where TEntity : BaseEntity where TRepository : class; 
    
    Task SaveAsync();
}