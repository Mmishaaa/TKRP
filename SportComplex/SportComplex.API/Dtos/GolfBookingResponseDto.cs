namespace SportComplex.API.Dtos
{
    public class GolfBookingResponseDto
    {
        public Guid Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }

        public Guid UserId { get; set; }
        public Guid GolfCourtId { get; set; }
        public Guid? CoachId { get; set; }
        public Guid? GolfEquipmentId { get; set; }
    }
}
