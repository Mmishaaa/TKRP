namespace SportComplex.DAL.Entities
{
    public class PingPongBookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        
        public Guid PingPongTableId { get; set; }
        public PingPongTableEntity? PingPongTable { get; set; }
        
        public Guid? CoachId { get; set; }
        public CoachEntity? Coach { get; set; }

        public Guid? PingPongEquipmentId { get; set; }
        public PingPongEquipmentEntity? PingPongEquipment { get; set; }
    }
}
