namespace SportComplex.API.Dtos
{
    public class TennisBookingRequestDto
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public Guid TennisCourtId { get; set; }
        public Guid? CoachId { get; set; }
        public Guid? TennisEquipmentId { get; set; }
    }
}
