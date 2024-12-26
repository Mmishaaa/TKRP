namespace SportComplex.DAL.Entities
{
    public class FootballBookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        public Guid FootballFieldId { get; set; }
        public FootballFieldEntity? FootballField { get; set; }

        public Guid? CoachId { get; set; }
        public CoachEntity? Coach { get; set; }

        public Guid? FootbalEquipmentId { get; set; }
        public FootballEquipmentEntity? FootbalEquipment { get; set; }
    }
}
