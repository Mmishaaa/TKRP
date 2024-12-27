namespace SportComplex.API.Dtos
{
    public class PaginationRequestDto
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
    }
}
