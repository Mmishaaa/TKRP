namespace SportComplex.API.Dtos
{
    public class PingPongEquipmentRequestDto
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
