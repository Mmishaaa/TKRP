namespace SportComplex.DAL.Entities
{
    public class TennisEquipmentEntity : BaseEntity
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
