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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserRequestDto userRequest, CancellationToken cancellationToken)
        {
            var userModel = _mapper.Map<UserModel>(userRequest);
            var createdUser = await _userService.CreateAsync(userModel, cancellationToken);
            var userResponse = _mapper.Map<UserResponseDto>(createdUser);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = userResponse.Id }, userResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByIdAsync(id, cancellationToken);
            var userResponse = _mapper.Map<UserResponseDto>(user);

            return Ok(userResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var userResponses = _mapper.Map<PagedResult<UserResponseDto>>(users);

            return Ok(userResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UserRequestDto userRequest, CancellationToken cancellationToken)
        {
            var userModel = _mapper.Map<UserModel>(userRequest);
            var updatedUser = await _userService.UpdateAsync(id, userModel, cancellationToken);
            var userResponse = _mapper.Map<UserResponseDto>(updatedUser);

            return Ok(userResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _userService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
