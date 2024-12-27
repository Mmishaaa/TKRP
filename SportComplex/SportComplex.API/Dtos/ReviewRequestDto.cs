namespace SportComplex.API.Dtos
{
    public class ReviewRequestDto
    {
        public string Description { get; set; } = string.Empty;
        public int StarsCount { get; set; }
        public Guid UserId { get; set; }
        public Guid CoachId { get; set; }
    }
}
