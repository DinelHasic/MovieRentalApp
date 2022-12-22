using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Direcor;
using MovieRental.Contract.DTOs.Director;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {

        private readonly IDirectorServices _directorServices;

        public DirectorController(IDirectorServices directorServices)
        {
            _directorServices = directorServices;
        }

        [HttpGet("directors/all")]
        [Authorize(Roles = "Admin")]
        public async Task<IEnumerable<DirectorSelectionDto>> GetAllDirectors()
        {
            IReadOnlyCollection<DirectorSelectionDto> directors = await _directorServices.GetAllDirectorsAsync();

            return directors;
        }

        [HttpPost("director/create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateDirector(CreateDirectorDto director)
        {
            await _directorServices.AddNewDirector(director);

            return Ok(director);
        }
    }
}
