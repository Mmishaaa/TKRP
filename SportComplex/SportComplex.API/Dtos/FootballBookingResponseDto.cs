namespace SportComplex.API.Dtos
{
    public class FootballBookingResponseDto
    {
        public Guid Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public Guid UserId { get; set; }
        public Guid FootballFieldId { get; set; }
        public Guid? CoachId { get; set; }
        public Guid? FootballEquipmentId { get; set; }
    }
}
