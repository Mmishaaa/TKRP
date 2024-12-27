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
    public class SwimmingPoolController : ControllerBase
    {
        private readonly ISwimmingPoolService _swimmingPoolService;
        private readonly IMapper _mapper;

        public SwimmingPoolController(ISwimmingPoolService swimmingPoolService, IMapper mapper)
        {
            _swimmingPoolService = swimmingPoolService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] SwimmingPoolRequestDto poolRequest, CancellationToken cancellationToken)
        {
            var poolModel = _mapper.Map<SwimmingPoolModel>(poolRequest);
            var createdPool = await _swimmingPoolService.CreateAsync(poolModel, cancellationToken);
            var poolResponse = _mapper.Map<SwimmingPoolResponseDto>(createdPool);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = poolResponse.Id }, poolResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var pool = await _swimmingPoolService.GetByIdAsync(id, cancellationToken);
            var poolResponse = _mapper.Map<SwimmingPoolResponseDto>(pool);

            return Ok(poolResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var pools = await _swimmingPoolService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var poolResponses = _mapper.Map<PagedResult<SwimmingPoolResponseDto>>(pools);

            return Ok(poolResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] SwimmingPoolRequestDto poolRequest, CancellationToken cancellationToken)
        {
            var poolModel = _mapper.Map<SwimmingPoolModel>(poolRequest);
            var updatedPool = await _swimmingPoolService.UpdateAsync(id, poolModel, cancellationToken);
            var poolResponse = _mapper.Map<SwimmingPoolResponseDto>(updatedPool);

            return Ok(poolResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _swimmingPoolService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
