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
    public class FootballFieldController : ControllerBase
    {
        private readonly IFootballFieldService _footballFieldService;
        private readonly IMapper _mapper;

        public FootballFieldController(IFootballFieldService footballFieldService, IMapper mapper)
        {
            _footballFieldService = footballFieldService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FootballFieldRequestDto fieldRequest, CancellationToken cancellationToken)
        {
            var fieldModel = _mapper.Map<FootballFieldModel>(fieldRequest);
            var createdField = await _footballFieldService.CreateAsync(fieldModel, cancellationToken);
            var fieldResponse = _mapper.Map<FootballFieldResponseDto>(createdField);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = fieldResponse.Id }, fieldResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var field = await _footballFieldService.GetByIdAsync(id, cancellationToken);
            var fieldResponse = _mapper.Map<FootballFieldResponseDto>(field);

            return Ok(fieldResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var fields = await _footballFieldService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var fieldResponses = _mapper.Map<PagedResult<FootballFieldResponseDto>>(fields);

            return Ok(fieldResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] FootballFieldRequestDto fieldRequest, CancellationToken cancellationToken)
        {
            var fieldModel = _mapper.Map<FootballFieldModel>(fieldRequest);
            var updatedField = await _footballFieldService.UpdateAsync(id, fieldModel, cancellationToken);
            var fieldResponse = _mapper.Map<FootballFieldResponseDto>(updatedField);

            return Ok(fieldResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _footballFieldService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
