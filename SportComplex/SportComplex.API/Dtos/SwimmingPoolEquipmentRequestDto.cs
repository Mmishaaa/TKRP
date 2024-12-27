namespace SportComplex.API.Dtos
{
    public class SwimmingPoolEquipmentRequestDto
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
