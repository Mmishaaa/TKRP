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
    public class SwimmingPoolEquipmentController : ControllerBase
    {
        private readonly ISwimmingPoolEquipmentService _swimmingPoolEquipmentService;
        private readonly IMapper _mapper;

        public SwimmingPoolEquipmentController(ISwimmingPoolEquipmentService swimmingPoolEquipmentService, IMapper mapper)
        {
            _swimmingPoolEquipmentService = swimmingPoolEquipmentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] SwimmingPoolEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<SwimmingPoolEquipmentModel>(equipmentRequest);
            var createdEquipment = await _swimmingPoolEquipmentService.CreateAsync(equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<SwimmingPoolEquipmentResponseDto>(createdEquipment);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = equipmentResponse.Id }, equipmentResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var equipment = await _swimmingPoolEquipmentService.GetByIdAsync(id, cancellationToken);
            var equipmentResponse = _mapper.Map<SwimmingPoolEquipmentResponseDto>(equipment);

            return Ok(equipmentResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var equipments = await _swimmingPoolEquipmentService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var equipmentResponses = _mapper.Map<PagedResult<SwimmingPoolEquipmentResponseDto>>(equipments);

            return Ok(equipmentResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] SwimmingPoolEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<SwimmingPoolEquipmentModel>(equipmentRequest);
            var updatedEquipment = await _swimmingPoolEquipmentService.UpdateAsync(id, equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<SwimmingPoolEquipmentResponseDto>(updatedEquipment);

            return Ok(equipmentResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _swimmingPoolEquipmentService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
