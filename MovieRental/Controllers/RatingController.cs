using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Rating;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {

        private readonly IRatingServices _ratingServices;

        public RatingController(IRatingServices ratingServices)
        {
            _ratingServices = ratingServices;
        }

        [HttpPost("rating/add")]
        [Authorize]
        public async Task<IActionResult> AddRatingAsync(CreateReatingDto ratingNew)
        {
            try
            {
              await _ratingServices.AddRatingAsync(ratingNew);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }

            return Ok(ratingNew);
        }
    }
}
