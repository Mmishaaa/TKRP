namespace SportComplex.BLL.Models
{
    public class GolfBookingModel
    {
        public Guid Id { get; set; }

        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }

        public Guid GolfCourtId { get; set; }
        public GolfCourtModel? GolfCourt { get; set; }

        public Guid? CoachId { get; set; }
        public CoachModel? Coach { get; set; }

        public Guid? GolfEquipmentId { get; set; }
        public GolfEquipmentModel? GolfEquipment { get; set; }
    }
}
