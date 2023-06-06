using DAL.Repository;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DbStartUp
{
    public static class InjectingDAL
    {
        public static void InjectDAL(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<DBContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Sql"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
