using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Data
{
    public static class DbStartup
    {
        public static void InitializeDb(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var context = provider.GetRequiredService<ApplicationDbContext>();
            context.InitDb();
        }
    }
}
