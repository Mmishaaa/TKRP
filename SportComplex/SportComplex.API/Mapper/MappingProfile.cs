using AutoMapper;
using SportComplex.API.Dtos;
using SportComplex.BLL.Models;

namespace SportComplex.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CoachRequestDto, CoachModel>();
            CreateMap<CoachModel, CoachResponseDto>();

            CreateMap<FootballBookingRequestDto, FootballBookingModel>();
            CreateMap<FootballBookingModel, FootballBookingResponseDto>();

            CreateMap<FootballEquipmentRequestDto, FootballEquipmentModel>();
            CreateMap<FootballEquipmentModel, FootballEquipmentResponseDto>();

            CreateMap<FootballFieldRequestDto, FootballFieldModel>();
            CreateMap<FootballFieldModel, FootballFieldResponseDto>();

            CreateMap<GolfBookingRequestDto, GolfBookingModel>();
            CreateMap<GolfBookingModel, GolfBookingResponseDto>();

            CreateMap<GolfEquipmentRequestDto, GolfEquipmentModel>();
            CreateMap<GolfEquipmentModel, GolfEquipmentResponseDto>();
            
            CreateMap<GolfCourtRequestDto, GolfCourtModel>();
            CreateMap<GolfCourtModel, GolfCourtResponseDto>();

            CreateMap<PingPongBookingRequestDto, PingPongBookingModel>();
            CreateMap<PingPongBookingModel, PingPongBookingResponseDto>();

            CreateMap<PingPongEquipmentRequestDto, PingPongEquipmentModel>();
            CreateMap<PingPongEquipmentModel, PingPongEquipmentResponseDto>();

            CreateMap<PingPongTableRequestDto, PingPongTableModel>();
            CreateMap<PingPongTableModel, PingPongTableResponseDto>();

            CreateMap<SwimmingPoolBookingRequestDto, SwimmingPoolBookingModel>();
            CreateMap<SwimmingPoolBookingModel, SwimmingPoolBookingResponseDto>();

            CreateMap<SwimmingPoolEquipmentRequestDto, SwimmingPoolEquipmentModel>();
            CreateMap<SwimmingPoolEquipmentModel, SwimmingPoolEquipmentResponseDto>();

            CreateMap<SwimmingPoolRequestDto, SwimmingPoolModel>();
            CreateMap<SwimmingPoolModel, SwimmingPoolResponseDto>();

            CreateMap<TennisBookingRequestDto, TennisBookingModel>();
            CreateMap<TennisBookingModel, TennisBookingResponseDto>();

            CreateMap<TennisEquipmentRequestDto, TennisEquipmentModel>();
            CreateMap<TennisEquipmentModel, TennisEquipmentResponseDto>();

            CreateMap<TennisCourtRequestDto, TennisCourtModel>();
            CreateMap<TennisCourtModel, TennisCourtResponseDto>();

            CreateMap<ReviewRequestDto, ReviewModel>();
            CreateMap<ReviewModel, ReviewResponseDto>();

            CreateMap<UserRequestDto, UserModel>();
            CreateMap<UserModel, UserResponseDto>();
        }
    }
}
