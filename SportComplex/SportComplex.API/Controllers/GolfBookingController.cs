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
    public class GolfBookingController : ControllerBase
    {
        private readonly IGolfBookingService _golfBookingService;
        private readonly IMapper _mapper;

        public GolfBookingController(IGolfBookingService golfBookingService, IMapper mapper)
        {
            _golfBookingService = golfBookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] GolfBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<GolfBookingModel>(bookingRequest);
            var createdBooking = await _golfBookingService.CreateAsync(bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<GolfBookingResponseDto>(createdBooking);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var booking = await _golfBookingService.GetByIdAsync(id, cancellationToken);
            var bookingResponse = _mapper.Map<GolfBookingResponseDto>(booking);

            return Ok(bookingResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var bookings = await _golfBookingService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var bookingResponses = _mapper.Map<PagedResult<GolfBookingResponseDto>>(bookings);

            return Ok(bookingResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] GolfBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<GolfBookingModel>(bookingRequest);
            var updatedBooking = await _golfBookingService.UpdateAsync(id, bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<GolfBookingResponseDto>(updatedBooking);

            return Ok(bookingResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _golfBookingService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
