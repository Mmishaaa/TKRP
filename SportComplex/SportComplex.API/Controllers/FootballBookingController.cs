using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SportComplex.API.Dtos;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.PaginationModels;

namespace SportComplex.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FootballBookingController : ControllerBase
    {
        private readonly IFootballBookingService _footballBookingService;
        private readonly IMapper _mapper;

        public FootballBookingController(IFootballBookingService footballBookingService, IMapper mapper)
        {
            _footballBookingService = footballBookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FootballBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<FootballBookingModel>(bookingRequest);
            var createdBooking = await _footballBookingService.CreateAsync(bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<FootballBookingResponseDto>(createdBooking);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var booking = await _footballBookingService.GetByIdAsync(id, cancellationToken);
            var bookingResponse = _mapper.Map<FootballBookingResponseDto>(booking);

            return Ok(bookingResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var bookings = await _footballBookingService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var bookingResponses = _mapper.Map<PagedResult<FootballBookingResponseDto>>(bookings);

            return Ok(bookingResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] FootballBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<FootballBookingModel>(bookingRequest);
            var updatedBooking = await _footballBookingService.UpdateAsync(id, bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<FootballBookingResponseDto>(updatedBooking);

            return Ok(bookingResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _footballBookingService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
