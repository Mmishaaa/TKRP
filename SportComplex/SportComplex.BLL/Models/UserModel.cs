namespace SportComplex.BLL.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<ReviewModel> Reviews { get; set; } = [];
    }
}
