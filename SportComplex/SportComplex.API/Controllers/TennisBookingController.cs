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
    public class TennisBookingController : ControllerBase
    {
        private readonly ITennisBookingService _tennisBookingService;
        private readonly IMapper _mapper;

        public TennisBookingController(ITennisBookingService tennisBookingService, IMapper mapper)
        {
            _tennisBookingService = tennisBookingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TennisBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<TennisBookingModel>(bookingRequest);
            var createdBooking = await _tennisBookingService.CreateAsync(bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<TennisBookingResponseDto>(createdBooking);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var booking = await _tennisBookingService.GetByIdAsync(id, cancellationToken);
            var bookingResponse = _mapper.Map<TennisBookingResponseDto>(booking);

            return Ok(bookingResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var bookings = await _tennisBookingService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var bookingResponses = _mapper.Map<PagedResult<TennisBookingResponseDto>>(bookings);

            return Ok(bookingResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TennisBookingRequestDto bookingRequest, CancellationToken cancellationToken)
        {
            var bookingModel = _mapper.Map<TennisBookingModel>(bookingRequest);
            var updatedBooking = await _tennisBookingService.UpdateAsync(id, bookingModel, cancellationToken);
            var bookingResponse = _mapper.Map<TennisBookingResponseDto>(updatedBooking);

            return Ok(bookingResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _tennisBookingService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
