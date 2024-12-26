namespace SportComplex.DAL.Entities
{
    public class CoachEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;

        public List<ReviewEntity> Reviews { get; set; }
    }
}
