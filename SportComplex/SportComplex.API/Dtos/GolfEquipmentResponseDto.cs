namespace SportComplex.API.Dtos
{
    public class GolfEquipmentResponseDto
    {
        public Guid Id { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
