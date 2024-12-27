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
    public class FootballEquipmentController : ControllerBase
    {
        private readonly IFootballEquipmentService _footballEquipmentService;
        private readonly IMapper _mapper;

        public FootballEquipmentController(IFootballEquipmentService footballEquipmentService, IMapper mapper)
        {
            _footballEquipmentService = footballEquipmentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FootballEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<FootballEquipmentModel>(equipmentRequest);
            var createdEquipment = await _footballEquipmentService.CreateAsync(equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<FootballEquipmentResponseDto>(createdEquipment);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = equipmentResponse.Id }, equipmentResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var equipment = await _footballEquipmentService.GetByIdAsync(id, cancellationToken);
            var equipmentResponse = _mapper.Map<FootballEquipmentResponseDto>(equipment);

            return Ok(equipmentResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var equipments = await _footballEquipmentService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var equipmentResponses = _mapper.Map<PagedResult<FootballEquipmentResponseDto>>(equipments);

            return Ok(equipmentResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] FootballEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<FootballEquipmentModel>(equipmentRequest);
            var updatedEquipment = await _footballEquipmentService.UpdateAsync(id, equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<FootballEquipmentResponseDto>(updatedEquipment);

            return Ok(equipmentResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _footballEquipmentService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
