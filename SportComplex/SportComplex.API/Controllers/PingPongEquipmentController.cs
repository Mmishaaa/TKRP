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
    public class PingPongEquipmentController : ControllerBase
    {
        private readonly IPingPongEquipmentService _pingPongEquipmentService;
        private readonly IMapper _mapper;

        public PingPongEquipmentController(IPingPongEquipmentService pingPongEquipmentService, IMapper mapper)
        {
            _pingPongEquipmentService = pingPongEquipmentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] PingPongEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<PingPongEquipmentModel>(equipmentRequest);
            var createdEquipment = await _pingPongEquipmentService.CreateAsync(equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<PingPongEquipmentResponseDto>(createdEquipment);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = equipmentResponse.Id }, equipmentResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var equipment = await _pingPongEquipmentService.GetByIdAsync(id, cancellationToken);
            var equipmentResponse = _mapper.Map<PingPongEquipmentResponseDto>(equipment);

            return Ok(equipmentResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var equipments = await _pingPongEquipmentService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var equipmentResponses = _mapper.Map<PagedResult<PingPongEquipmentResponseDto>>(equipments);

            return Ok(equipmentResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] PingPongEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<PingPongEquipmentModel>(equipmentRequest);
            var updatedEquipment = await _pingPongEquipmentService.UpdateAsync(id, equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<PingPongEquipmentResponseDto>(updatedEquipment);

            return Ok(equipmentResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _pingPongEquipmentService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
