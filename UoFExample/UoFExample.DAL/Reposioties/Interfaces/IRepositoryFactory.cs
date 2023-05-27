using UoFExample.DAL.Entities;

namespace UoFExample.DAL.Reposioties.Interfaces;

public interface IRepositoryFactory
{
    public TRepository Create<TEntity, TRepository>() where TEntity : BaseEntity where TRepository : class;
}