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
    public class PingPongBookingController : ControllerBase
    {
        private readonly IPingPongBookingService _pingPongBookingService;
        private readonly IMapper _mapper;

        public PingPongBookingController(IPingPongBookingService pingPongBookingService, IMapper mapper)
        {
            _pingPongBookingService = pingPongBookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PingPongBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<PingPongBookingModel>(bookingRequest);
            var createdBooking = await _pingPongBookingService.CreateAsync(bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<PingPongBookingResponseDto>(createdBooking);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var booking = await _pingPongBookingService.GetByIdAsync(id, cancellationToken);
            var bookingResponse = _mapper.Map<PingPongBookingResponseDto>(booking);

            return Ok(bookingResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var bookings = await _pingPongBookingService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var bookingResponses = _mapper.Map<PagedResult<PingPongBookingResponseDto>>(bookings);

            return Ok(bookingResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] PingPongBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<PingPongBookingModel>(bookingRequest);
            var updatedBooking = await _pingPongBookingService.UpdateAsync(id, bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<PingPongBookingResponseDto>(updatedBooking);

            return Ok(bookingResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _pingPongBookingService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
