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
    public class CoachController : ControllerBase
    {
        private readonly ICoachService _coachService;
        private readonly IMapper _mapper;

        public CoachController(ICoachService coachService, IMapper mapper)
        {
            _coachService = coachService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CoachRequestDto coachRequest, CancellationToken cancellationToken)
        {
            var coachModel = _mapper.Map<CoachModel>(coachRequest);
            var createdCoach = await _coachService.CreateAsync(coachModel, cancellationToken);
            var coachResponse = _mapper.Map<CoachResponseDto>(createdCoach);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = coachResponse.Id }, coachResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var coach = await _coachService.GetByIdAsync(id, cancellationToken);
            var coachResponse = _mapper.Map<CoachResponseDto>(coach);

            return Ok(coachResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var coaches = await _coachService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var coachResponses = _mapper.Map<PagedResult<CoachResponseDto>>(coaches);

            return Ok(coachResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] CoachRequestDto coachRequest, CancellationToken cancellationToken)
        {
            var coachModel = _mapper.Map<CoachModel>(coachRequest);
            var updatedCoach = await _coachService.UpdateAsync(id, coachModel, cancellationToken);
            var coachResponse = _mapper.Map<CoachResponseDto>(updatedCoach);

            return Ok(coachResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _coachService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
