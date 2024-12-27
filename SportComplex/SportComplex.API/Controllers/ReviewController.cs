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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public ReviewController(IReviewService reviewService, IMapper mapper)
        {
            _reviewService = reviewService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ReviewRequestDto reviewRequest, CancellationToken cancellationToken)
        {
            var reviewModel = _mapper.Map<ReviewModel>(reviewRequest);
            var createdReview = await _reviewService.CreateAsync(reviewModel, cancellationToken);
            var reviewResponse = _mapper.Map<ReviewResponseDto>(createdReview);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = reviewResponse.Id }, reviewResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var review = await _reviewService.GetByIdAsync(id, cancellationToken);
            var reviewResponse = _mapper.Map<ReviewResponseDto>(review);

            return Ok(reviewResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationRequestDto paginationRequest, CancellationToken cancellationToken)
        {
            var reviews = await _reviewService.GetAllAsync(paginationRequest.PageNumber, paginationRequest.PageSize, cancellationToken);
            var reviewResponses = _mapper.Map<PagedResult<ReviewResponseDto>>(reviews);

            return Ok(reviewResponses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] ReviewRequestDto reviewRequest, CancellationToken cancellationToken)
        {
            var reviewModel = _mapper.Map<ReviewModel>(reviewRequest);
            var updatedReview = await _reviewService.UpdateAsync(id, reviewModel, cancellationToken);
            var reviewResponse = _mapper.Map<ReviewResponseDto>(updatedReview);

            return Ok(reviewResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _reviewService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
