using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SportComplex.DAL.Interfaces;
using SportComplex.DAL.Repositories;

namespace SportComplex.DAL.DI
{
    public static class DependencyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(cfg
                => cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICoachRepository, CoachRepository>();
            services.AddScoped<IGolfBookingRepository, GolfBookingRepository>();
            services.AddScoped<IGolfCourtRepository, GolfCourtRepository>();
            services.AddScoped<IGolfEquipmentRepository, GolfEquipmentRepository>();
            services.AddScoped<IPingPongBookingRepository, PingPongBookingRepository>();
            services.AddScoped<IPingPongEquipmentRepository, PingPongEquipmentRepository>();
            services.AddScoped<IPingPongTableRepository, PingPongTableRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<ISwimmingPoolBookingRepository, SwimmingPoolBookingRepository>();
            services.AddScoped<ISwimmingPoolRepository, SwimmingPoolRepository>();
            services.AddScoped<ISwimmingPoolEquipmentRepository, SwimmingPoolEquipmentRepository>();
            services.AddScoped<ITennisCourtRepository, TennisCourtRepository>();
            services.AddScoped<ITennisEquipmentRepository, TennisEquipmentRepository>();
            services.AddScoped<ITennisBookingRepository, TennisBookingRepository>();
            services.AddScoped<IFootballBookingRepository, FootballBookingRepository>();
            services.AddScoped<IFootballEquipmentRepository, FootballEquipmentRepository>();
            services.AddScoped<IFootballFieldRepository, FootballFieldRepository>();
        }
    }
}
