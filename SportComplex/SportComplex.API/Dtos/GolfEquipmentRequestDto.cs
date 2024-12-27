namespace SportComplex.API.Dtos
{
    public class GolfEquipmentRequestDto
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
