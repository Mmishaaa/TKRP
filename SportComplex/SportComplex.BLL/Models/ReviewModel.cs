namespace SportComplex.BLL.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int StarsCount { get; set; }

        public Guid UserId { get; set; }
        public UserModel? User { get; set; }
        public Guid CoachId { get; set; }
        public CoachModel? Coach { get; set; }
    }
}
