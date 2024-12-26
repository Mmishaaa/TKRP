namespace SportComplex.DAL.Entities
{
    public class SwimmingPoolEquipmentEntity : BaseEntity
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
