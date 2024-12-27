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
    public class GolfEquipmentController : ControllerBase
    {
        private readonly IGolfEquipmentService _golfEquipmentService;
        private readonly IMapper _mapper;

        public GolfEquipmentController(IGolfEquipmentService golfEquipmentService, IMapper mapper)
        {
            _golfEquipmentService = golfEquipmentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] GolfEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<GolfEquipmentModel>(equipmentRequest);
            var createdEquipment = await _golfEquipmentService.CreateAsync(equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<GolfEquipmentResponseDto>(createdEquipment);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = equipmentResponse.Id }, equipmentResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var equipment = await _golfEquipmentService.GetByIdAsync(id, cancellationToken);
            var equipmentResponse = _mapper.Map<GolfEquipmentResponseDto>(equipment);

            return Ok(equipmentResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var equipments = await _golfEquipmentService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var equipmentResponses = _mapper.Map<PagedResult<GolfEquipmentResponseDto>>(equipments);

            return Ok(equipmentResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] GolfEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<GolfEquipmentModel>(equipmentRequest);
            var updatedEquipment = await _golfEquipmentService.UpdateAsync(id, equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<GolfEquipmentResponseDto>(updatedEquipment);

            return Ok(equipmentResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _golfEquipmentService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
