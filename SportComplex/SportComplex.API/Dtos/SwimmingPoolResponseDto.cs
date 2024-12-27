﻿namespace SportComplex.API.Dtos
{
    public class SwimmingPoolResponseDto
    {
        public Guid Id { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}
