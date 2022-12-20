using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Genre;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreServices _genreServices;

        public GenreController(IGenreServices genreServices)
        {
            _genreServices = genreServices;
        }

        [HttpGet("genre/all")]
        public async Task<ActionResult<IEnumerable<GenreDto>>> GetAllGenresAsync()
        {
            IReadOnlyCollection<GenreDto> genres = await _genreServices.GetAllGenresAsync();

            return Ok(genres);
        }
    }
}
