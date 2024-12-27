namespace SportComplex.BLL.Models
{
    public class SwimmingPoolBookingModel
    {
        public Guid Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }

        public Guid SwimmingPoolId { get; set; }
        public SwimmingPoolModel? SwimmingPool { get; set; }

        public Guid? CoachId { get; set; }
        public CoachModel? Coach { get; set; }

        public Guid? SwimmingPoolEquipmentId { get; set; }
        public SwimmingPoolEquipmentModel? SwimmingPoolEquipment { get; set; }
    }
}
