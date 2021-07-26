using Demo.Core.Contracts;
using Demo.Core.Data;
using Demo.Core.Services;
using Demo.Infrastructure.Contracts;
using Demo.Infrastructure.Data;
using Demo.Infrastructure.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Api
{
    public class DependencyRegistrar
    {
        public static void RegisterDependencies(IServiceCollection services,string connectionString)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IPersonService), typeof(PersonService));

            services.AddScoped(typeof(ISqlConnectionFactory), (x) => new PSqlConnectionFactory(connectionString));

        }
    }
}
