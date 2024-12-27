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
    public class GolfCourtController : ControllerBase
    {
        private readonly IGolfCourtService _golfCourtService;
        private readonly IMapper _mapper;

        public GolfCourtController(IGolfCourtService golfCourtService, IMapper mapper)
        {
            _golfCourtService = golfCourtService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] GolfCourtRequestDto courtRequest, CancellationToken cancellationToken)
        {
            var courtModel = _mapper.Map<GolfCourtModel>(courtRequest);
            var createdCourt = await _golfCourtService.CreateAsync(courtModel, cancellationToken);
            var courtResponse = _mapper.Map<GolfCourtResponseDto>(createdCourt);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = courtResponse.Id }, courtResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var court = await _golfCourtService.GetByIdAsync(id, cancellationToken);
            var courtResponse = _mapper.Map<GolfCourtResponseDto>(court);

            return Ok(courtResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var courts = await _golfCourtService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var courtResponses = _mapper.Map<PagedResult<GolfCourtResponseDto>>(courts);

            return Ok(courtResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] GolfCourtRequestDto courtRequest, CancellationToken cancellationToken)
        {
            var courtModel = _mapper.Map<GolfCourtModel>(courtRequest);
            var updatedCourt = await _golfCourtService.UpdateAsync(id, courtModel, cancellationToken);
            var courtResponse = _mapper.Map<GolfCourtResponseDto>(updatedCourt);

            return Ok(courtResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _golfCourtService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
