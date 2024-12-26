namespace SportComplex.DAL.Entities
{
    public class TennisBookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        public Guid TennisCourtId { get; set; }
        public TennisCourtEntity? TennisCourt { get; set; }

        public Guid? CoachId { get; set; }
        public CoachEntity? Coach { get; set; }

        public Guid? TennisEquipmentId { get; set; }
        public TennisEquipmentEntity? TennisEquipment { get; set; }
    }
}
