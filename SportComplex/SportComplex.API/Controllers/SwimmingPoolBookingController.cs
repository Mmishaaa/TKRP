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
    public class SwimmingPoolBookingController : ControllerBase
    {
        private readonly ISwimmingPoolBookingService _swimmingPoolBookingService;
        private readonly IMapper _mapper;

        public SwimmingPoolBookingController(ISwimmingPoolBookingService swimmingPoolBookingService, IMapper mapper)
        {
            _swimmingPoolBookingService = swimmingPoolBookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] SwimmingPoolBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<SwimmingPoolBookingModel>(bookingRequest);
            var createdBooking = await _swimmingPoolBookingService.CreateAsync(bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<SwimmingPoolBookingResponseDto>(createdBooking);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var booking = await _swimmingPoolBookingService.GetByIdAsync(id, cancellationToken);
            var bookingResponse = _mapper.Map<SwimmingPoolBookingResponseDto>(booking);

            return Ok(bookingResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var bookings = await _swimmingPoolBookingService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var bookingResponses = _mapper.Map<PagedResult<SwimmingPoolBookingResponseDto>>(bookings);

            return Ok(bookingResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] SwimmingPoolBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<SwimmingPoolBookingModel>(bookingRequest);
            var updatedBooking = await _swimmingPoolBookingService.UpdateAsync(id, bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<SwimmingPoolBookingResponseDto>(updatedBooking);

            return Ok(bookingResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _swimmingPoolBookingService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
