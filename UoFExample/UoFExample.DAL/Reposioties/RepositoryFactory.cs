using Microsoft.Extensions.DependencyInjection;
using UoFExample.DAL.Entities;
using UoFExample.DAL.Reposioties.Interfaces;

namespace UoFExample.DAL.Reposioties;

public class RepositoryFactory : IRepositoryFactory
{
    private readonly IServiceProvider _serviceProvider;

    public RepositoryFactory(IServiceProvider provider)
    {
        _serviceProvider = provider;
    }

    public TRepository Create<TEntity, TRepository>() where TEntity : BaseEntity where TRepository : class
    {
        switch (typeof(TEntity))
        {
            case var type when type == typeof(Game):
                return _serviceProvider.GetRequiredService<IGameRepository>() as TRepository;
            case var type when type == typeof(Genre):
                return _serviceProvider.GetRequiredService<IGenreRepository>() as TRepository;
            default:
                throw new ArgumentException($"No repo for type {typeof(TEntity)}");
        }
    }
}