using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UoFExample.DAL.Reposioties;
using UoFExample.DAL.Reposioties.Interfaces;
using UoFExample.DAL.UoF;

namespace UoFExample.DAL.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddDataBase(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataBaseContext>(options =>
            options.UseSqlServer(config.GetConnectionString("SqlConnection")));
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGameRepository, GameRepository>();
        services.AddScoped<IGenreRepository, GenreRepository>();

        services.AddScoped<IRepositoryFactory, RepositoryFactory>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}