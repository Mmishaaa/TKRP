using Microsoft.EntityFrameworkCore;
using SportComplex.DAL.Entities;

namespace SportComplex.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //if(Database.IsRelational())
            //{
            //    Database.Migrate();
            //}
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CoachEntity> Coaches { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }

        public DbSet<FootballBookingEntity> FootballBookings { get; set; }
        public DbSet<FootballFieldEntity> FootballFields { get; set; }
        public DbSet<FootballEquipmentEntity> FootballEquipments { get; set; }

        public DbSet<GolfBookingEntity> GolfBookings { get; set; }
        public DbSet<GolfCourtEntity> GolfCourts { get; set; }
        public DbSet<GolfEquipmentEntity> GolfEquipments { get; set; }

        public DbSet<PingPongBookingEntity> PingPongBookings { get; set; }
        public DbSet<PingPongTableEntity> PingPongTables { get; set; }
        public DbSet<PingPongEquipmentEntity> PingPongEquipments { get; set; }

        public DbSet<SwimmingPoolBookingEntity> SwimmingPoolBookings { get; set; }
        public DbSet<SwimmingPoolEntity> SwimmingPools { get; set; }
        public DbSet<SwimmingPoolEquipmentEntity> SwimmingPoolEquipments { get; set; }

        public DbSet<TennisBookingEntity> TennisBookings { get; set; }
        public DbSet<TennisCourtEntity> TennisCourts { get; set; }
        public DbSet<TennisEquipmentEntity> TennisEquipments { get; set; }
    }

    
}
