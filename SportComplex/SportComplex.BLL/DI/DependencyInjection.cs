using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Mapper;
using SportComplex.BLL.Services;
using SportComplex.DAL.DI;

namespace SportComplex.BLL.DI
{
    public static class DependencyInjection
    {
        public static void AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDataAccessLayer(configuration);

            services.AddScoped<ICoachService, CoachService>();
            services.AddScoped<IFootballBookingService, FootballBookingService>();
            services.AddScoped<IFootballEquipmentService, FootballEquipmentService>();
            services.AddScoped<IFootballFieldService, FootballFieldService>();
            services.AddScoped<IGolfBookingService, GolfBookingService>();
            services.AddScoped<IGolfCourtService, GolfCourtService>();
            services.AddScoped<IGolfEquipmentService, GolfEquipmentService>();
            services.AddScoped<IPingPongBookingService, PingPongBookingService>();
            services.AddScoped<IPingPongEquipmentService, PingPongEquipmentService>();
            services.AddScoped<IPingPongTableService, PingPongTableService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ISwimmingPoolBookingService, SwimmingPoolBookingService>();
            services.AddScoped<ISwimmingPoolEquipmentService, SwimmingPoolEquipmentService>();
            services.AddScoped<ISwimmingPoolService, SwimmingPoolService>();
            services.AddScoped<ITennisBookingService, TennisBookingService>();
            services.AddScoped<ITennisCourtService, TennisCourtService>();
            services.AddScoped<ITennisEquipmentService, TennisEquipmentService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
