namespace SportComplex.BLL.Models
{
    public class SwimmingPoolEquipmentModel
    {
        public Guid Id { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
