namespace SportComplex.API.Dtos
{
    public class ReviewResponseDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int StarsCount { get; set; }
        public Guid UserId { get; set; }
        public Guid CoachId { get; set; }
    }
}
