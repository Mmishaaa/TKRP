using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SportComplex.DAL.DI
{
    public static class DependencyInjection
    {
        public static void AddDataAccesLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(cfg
                => cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
