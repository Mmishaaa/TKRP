namespace SportComplex.BLL.Models
{
    public class PingPongBookingModel
    {
        public Guid Id { get; set; }

        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }

        public Guid PingPongTableId { get; set; }
        public PingPongTableModel? PingPongTable { get; set; }

        public Guid? CoachId { get; set; }
        public CoachModel? Coach { get; set; }

        public Guid? PingPongEquipmentId { get; set; }
        public PingPongEquipmentModel? PingPongEquipment { get; set; }
    }
}
