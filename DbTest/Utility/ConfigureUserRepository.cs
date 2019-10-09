using DbTest.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Utility
{
    public static class ConfigureUserRepository
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserConfiguration>();
        }
    }
}
