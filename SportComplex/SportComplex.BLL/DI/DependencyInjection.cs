using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportComplex.DAL.DI;

namespace SportComplex.BLL.DI
{
    public static class DependencyInjection
    {
        public static void AddBuisnessLogicLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessLayer(configuration);
        }
    }
}
