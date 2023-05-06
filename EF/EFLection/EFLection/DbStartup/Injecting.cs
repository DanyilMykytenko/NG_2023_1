using EFLection.Service;
using Microsoft.EntityFrameworkCore;

namespace EFLection.DbStartup
{
    public static class Injecting
    {
        public static void Inject(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<EFLectionContext>(options =>
            {
                options.UseSqlServer(
                    configuration["ConnectionString"]);
            });
            services.AddScoped<DbService>();
        }
    }
}
