namespace SportComplex.DAL.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<ReviewEntity> Reviews { get; set; } = [];
    }
}
