using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportComplex.BLL.Mapper;
using SportComplex.DAL.DI;

namespace SportComplex.BLL.DI
{
    public static class DependencyInjection
    {
        public static void AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDataAccesLayer(configuration);
        }
    }
}
