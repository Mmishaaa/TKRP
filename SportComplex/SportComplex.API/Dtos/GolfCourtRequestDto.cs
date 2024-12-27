﻿namespace SportComplex.API.Dtos
{
    public class GolfCourtRequestDto
    {
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}