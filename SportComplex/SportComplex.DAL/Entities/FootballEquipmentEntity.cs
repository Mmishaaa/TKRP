namespace SportComplex.DAL.Entities
{
    public class FootballEquipmentEntity : BaseEntity
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
