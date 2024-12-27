namespace SportComplex.BLL.Models
{
    public class CoachModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;

        public List<ReviewModel> Reviews { get; set; }
    }
}
