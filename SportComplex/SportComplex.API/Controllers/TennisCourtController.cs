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
    public class TennisCourtController : ControllerBase
    {
        private readonly ITennisCourtService _tennisCourtService;
        private readonly IMapper _mapper;

        public TennisCourtController(ITennisCourtService tennisCourtService, IMapper mapper)
        {
            _tennisCourtService = tennisCourtService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TennisCourtRequestDto courtRequest, CancellationToken cancellationToken)
        {
            var courtModel = _mapper.Map<TennisCourtModel>(courtRequest);
            var createdCourt = await _tennisCourtService.CreateAsync(courtModel, cancellationToken);
            var courtResponse = _mapper.Map<TennisCourtResponseDto>(createdCourt);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = courtResponse.Id }, courtResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var court = await _tennisCourtService.GetByIdAsync(id, cancellationToken);
            var courtResponse = _mapper.Map<TennisCourtResponseDto>(court);

            return Ok(courtResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var courts = await _tennisCourtService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var courtResponses = _mapper.Map<PagedResult<TennisCourtResponseDto>>(courts);

            return Ok(courtResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TennisCourtRequestDto courtRequest, CancellationToken cancellationToken)
        {
            var courtModel = _mapper.Map<TennisCourtModel>(courtRequest);
            var updatedCourt = await _tennisCourtService.UpdateAsync(id, courtModel, cancellationToken);
            var courtResponse = _mapper.Map<TennisCourtResponseDto>(updatedCourt);

            return Ok(courtResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _tennisCourtService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
