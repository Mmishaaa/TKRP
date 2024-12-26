namespace SportComplex.DAL.Entities
{
    public class GolfBookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        public Guid GolfCourtId { get; set; }
        public GolfCourtEntity? GolfCourt { get; set; }
        
        public Guid? CoachId { get; set; }
        public CoachEntity? Coach { get; set; }

        public Guid? GolfEquipmentId { get; set; }
        public GolfEquipmentEntity? GolfEquipment { get; set; }

    }
}
