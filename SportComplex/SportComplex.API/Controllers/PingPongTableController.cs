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
    public class PingPongTableController : ControllerBase
    {
        private readonly IPingPongTableService _pingPongTableService;
        private readonly IMapper _mapper;

        public PingPongTableController(IPingPongTableService pingPongTableService, IMapper mapper)
        {
            _pingPongTableService = pingPongTableService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PingPongTableRequestDto tableRequest, CancellationToken cancellationToken)
        {
            var tableModel = _mapper.Map<PingPongTableModel>(tableRequest);
            var createdTable = await _pingPongTableService.CreateAsync(tableModel, cancellationToken);
            var tableResponse = _mapper.Map<PingPongTableResponseDto>(createdTable);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = tableResponse.Id }, tableResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var table = await _pingPongTableService.GetByIdAsync(id, cancellationToken);
            var tableResponse = _mapper.Map<PingPongTableResponseDto>(table);

            return Ok(tableResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var tables = await _pingPongTableService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var tableResponses = _mapper.Map<PagedResult<PingPongTableResponseDto>>(tables);

            return Ok(tableResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] PingPongTableRequestDto tableRequest, CancellationToken cancellationToken)
        {
            var tableModel = _mapper.Map<PingPongTableModel>(tableRequest);
            var updatedTable = await _pingPongTableService.UpdateAsync(id, tableModel, cancellationToken);
            var tableResponse = _mapper.Map<PingPongTableResponseDto>(updatedTable);

            return Ok(tableResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _pingPongTableService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
