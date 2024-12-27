namespace SportComplex.BLL.Models
{
    public class FootballBookingModel
    {
        public Guid Id { get; set; }

        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }

        public Guid FootballFieldId { get; set; }
        public FootballFieldModel? FootballField { get; set; }

        public Guid? CoachId { get; set; }
        public CoachModel? Coach { get; set; }

        public Guid? FootballEquipmentId { get; set; }
        public FootballEquipmentModel? FootballEquipment { get; set; }
    }
}
