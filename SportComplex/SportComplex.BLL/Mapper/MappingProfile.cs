using AutoMapper;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;

namespace SportComplex.BLL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CoachEntity, CoachModel>().ReverseMap();

            CreateMap<FootballBookingEntity, FootballBookingModel>().ReverseMap();
            CreateMap<FootballEquipmentEntity, FootballEquipmentModel>().ReverseMap();
            CreateMap<FootballFieldEntity, FootballFieldModel>().ReverseMap();

            CreateMap<GolfBookingEntity, GolfBookingModel>().ReverseMap();
            CreateMap<GolfCourtEntity, GolfCourtModel>().ReverseMap();
            CreateMap<GolfEquipmentEntity, GolfEquipmentModel>().ReverseMap();

            CreateMap<PingPongBookingEntity, PingPongBookingModel>().ReverseMap();
            CreateMap<PingPongEquipmentEntity, PingPongEquipmentModel>().ReverseMap();
            CreateMap<PingPongTableEntity, PingPongTableModel>().ReverseMap();

            CreateMap<ReviewEntity, ReviewModel>().ReverseMap();

            CreateMap<SwimmingPoolBookingEntity, SwimmingPoolBookingModel>().ReverseMap();
            CreateMap<SwimmingPoolEquipmentEntity, SwimmingPoolEquipmentModel>().ReverseMap();
            CreateMap<SwimmingPoolEntity, SwimmingPoolModel>().ReverseMap();

            CreateMap<TennisBookingEntity, TennisBookingModel>().ReverseMap();
            CreateMap<TennisCourtEntity, TennisCourtModel>().ReverseMap();
            CreateMap<TennisEquipmentEntity, TennisEquipmentModel>().ReverseMap();

            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
