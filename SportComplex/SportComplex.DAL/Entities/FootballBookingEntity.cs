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

        public Guid? FootballEquipmentId { get; set; }
        public FootballEquipmentEntity? FootballEquipment { get; set; }
    }
}
