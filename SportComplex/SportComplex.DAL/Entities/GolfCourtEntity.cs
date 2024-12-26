namespace SportComplex.DAL.Entities
{
    public class GolfCourtEntity : BaseEntity
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}
