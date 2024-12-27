namespace SportComplex.BLL.Models
{
    public class TennisBookingModel
    {
        public Guid Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }

        public Guid TennisCourtId { get; set; }
        public TennisCourtModel? TennisCourt { get; set; }

        public Guid? CoachId { get; set; }
        public CoachModel? Coach { get; set; }

        public Guid? TennisEquipmentId { get; set; }
        public TennisCourtModel? TennisEquipment { get; set; }
    }
}
