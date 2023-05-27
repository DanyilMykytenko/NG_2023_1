using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class AddServices
    {
        public static void AddServiceInjection(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(AppMappingProfile));
        }
    }
}
