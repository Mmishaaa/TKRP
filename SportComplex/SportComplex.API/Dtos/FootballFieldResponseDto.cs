﻿namespace SportComplex.API.Dtos
{
    public class FootballFieldResponseDto
    {
        public Guid Id { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}
