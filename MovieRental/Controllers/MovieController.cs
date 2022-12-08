using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Movie;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet("movie/get/all")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetAllMovie()
        {
           IEnumerable<MovieDto> movies = await _movieServices.GetAllMoviesAsync();

            return Ok(movies);
        }


        [HttpPost("movie/create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateMovie(MovieCreateDto newMovie)
        {
            await _movieServices.AddNewMovieAsync(newMovie);

            return Ok(newMovie);
        }

        [HttpDelete("movie/delete")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _movieServices.RemoveMovieByIdAsync(id);
            
            return Ok();
        }

        [HttpGet("movie/details/{id}")]
        [Authorize]
        public async Task<ActionResult<MovieDetailsDto>> MovieDetails([FromRoute] int id)
        {
            MovieDetailsDto movie = await _movieServices.GetMovieByIdAsync(id);

            return Ok(movie);
        }

    }
}
