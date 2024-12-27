namespace SportComplex.API.Dtos
{
    public class SwimmingPoolBookingRequestDto
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public Guid SwimmingPoolId { get; set; }
        public Guid? CoachId { get; set; }
        public Guid? SwimmingPoolEquipmentId { get; set; }
    }
}
