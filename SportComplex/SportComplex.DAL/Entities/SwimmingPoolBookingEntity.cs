namespace SportComplex.DAL.Entities
{
    public class SwimmingPoolBookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        public Guid SwimmingPoolId { get; set; }
        public SwimmingPoolEntity? SwimmingPool { get; set; }

        public Guid? CoachId { get; set; }
        public CoachEntity? Coach { get; set; }

        public Guid? SwimmingPoolEquipmentId { get; set; }
        public SwimmingPoolEquipmentEntity? SwimmingPoolEquipment { get; set; }
    }
}
