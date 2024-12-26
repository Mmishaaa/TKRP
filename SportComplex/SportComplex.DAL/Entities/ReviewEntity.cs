namespace SportComplex.DAL.Entities
{
    public class ReviewEntity : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int StarsCount { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public Guid CoachId { get; set; }
        public CoachEntity? Coach { get; set; }
    }
}
