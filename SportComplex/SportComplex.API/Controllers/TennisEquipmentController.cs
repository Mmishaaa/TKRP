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
    public class TennisEquipmentController : ControllerBase
    {
        private readonly ITennisEquipmentService _tennisEquipmentService;
        private readonly IMapper _mapper;

        public TennisEquipmentController(ITennisEquipmentService tennisEquipmentService, IMapper mapper)
        {
            _tennisEquipmentService = tennisEquipmentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TennisEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<TennisEquipmentModel>(equipmentRequest);
            var createdEquipment = await _tennisEquipmentService.CreateAsync(equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<TennisEquipmentResponseDto>(createdEquipment);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = equipmentResponse.Id }, equipmentResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var equipment = await _tennisEquipmentService.GetByIdAsync(id, cancellationToken);
            var equipmentResponse = _mapper.Map<TennisEquipmentResponseDto>(equipment);

            return Ok(equipmentResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var equipments = await _tennisEquipmentService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var equipmentResponses = _mapper.Map<PagedResult<TennisEquipmentResponseDto>>(equipments);

            return Ok(equipmentResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TennisEquipmentRequestDto equipmentRequest, CancellationToken cancellationToken)
        {
            var equipmentModel = _mapper.Map<TennisEquipmentModel>(equipmentRequest);
            var updatedEquipment = await _tennisEquipmentService.UpdateAsync(id, equipmentModel, cancellationToken);
            var equipmentResponse = _mapper.Map<TennisEquipmentResponseDto>(updatedEquipment);

            return Ok(equipmentResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _tennisEquipmentService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
