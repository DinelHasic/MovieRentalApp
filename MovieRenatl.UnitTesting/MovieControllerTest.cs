using Microsoft.AspNetCore.Mvc;
using Moq;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Direcor;
using MovieRental.Contract.DTOs.Genre;
using MovieRental.Contract.DTOs.Movie;
using MovieRental.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MovieRental.UnitTesting
{
    public class MovieControllerTest
    {
        private readonly MovieController? _movieController;

        private readonly Mock<IMovieServices> _movieServices;

        public MovieControllerTest()
        {
            _movieServices = new Mock<IMovieServices>();
            _movieController = new MovieController(_movieServices.Object);
        }

        [Fact]
        public async Task CreateMovieAsync_ShuldReturnBadRequest_WhenEmptyMovieCreateDtoPassed()
        {

            //Arrange
            MovieCreateDto? movieCreateDto = null;

            Type expected = typeof(BadRequestResult);

            //Act
            IActionResult result = await _movieController!.CreateMovieAsync(movieCreateDto!);


            //Assert
            Assert.Equal(expected, result.GetType());
        }

        [Fact]
        public async Task CreateMovieAsync_ShuldCreateNewMovie_WhenValidMovieCreateDtoIsPassed()
        {

            //Arrange
            MovieCreateDto movieCreateDto = new MovieCreateDto()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = new List<int>() { 1, 2, 3 },
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<int>() { 1 },
                Year = new DateTime(2008, 2, 12)
            };

            Type expected = typeof(OkObjectResult);

            //Act
            IActionResult result = await _movieController!.CreateMovieAsync(movieCreateDto!);

            //Assert
            Assert.Equal(expected, result.GetType());
        }



        [Fact]
        public async Task GetAllMovieAsync_ShouldReturnAllMovies()
        {
            //Arrange
            Type expected = typeof(OkObjectResult);

            //Act
            ActionResult<IEnumerable<MovieDto>> result = await _movieController!.GetAllMovieAsync();

            Type resultStatus = result!.Result!.GetType();

            //Assert
            Assert.Equal(expected, resultStatus);
        }

        [Fact]
        public async Task GetMovieDetailAsync_ShouldReturnMovieDetailsDto_WhenIdIsValid()
        {
            //Arrange
            MovieDetailsDto expectedData = new()
            {

                Title = "E.T",
                Description = "Alien in planet earth with a young boy",
                Genres = new List<GenreDto>()
                {
                  new GenreDto()
                  {
                       GenreId = 1,
                       GenreTitle = "Drama"
                  },
                  new GenreDto()
                  {
                       GenreId = 2,
                       GenreTitle = "Comedy"
                  }
                },
                Year = new DateTime(1982, 02, 01),
                ImageUrl = "https://m.media-amazon.com/images/I/814-9+LgNTL._AC_SY445_.jpg",
                Rating = 9.5,
                Directors = new List<DirectorDto>()
                {
                  new DirectorDto()
                  {
                          FirstName = "Steven",
                          LastName ="Spielberg",
                          Image_Url = "https://upload.wikimedia.org/wikipedia/commons/6/67/Steven_Spielberg_by_Gage_Skidmore.jpg"
                  }
                }
            };

            Type expectedType = typeof(OkObjectResult);



            _movieServices.Setup(x => x.GetMovieByIdAsync(1)).ReturnsAsync(expectedData);



            //Act
            ActionResult<MovieDetailsDto> result = await _movieController!.GetMovieDetailAsync(1);

            //Assert
            Type resultStatus = result!.Result!.GetType();

            Assert.Equal(expectedType, resultStatus);

            OkObjectResult castedResult = (OkObjectResult) result.Result!;

            MovieDetailsDto resultData = (MovieDetailsDto)castedResult.Value!;

            Assert.Equal(expectedData.Title, resultData.Title);
            Assert.Equal(expectedData.Description,resultData.Description);
            Assert.Equal(expectedData.Genres, resultData.Genres);
            Assert.Equal(expectedData.Directors, resultData.Directors);
            Assert.Equal(expectedData.ImageUrl, resultData.ImageUrl);
            Assert.Equal(expectedData.Rating, resultData.Rating);
            Assert.Equal(expectedData.Year,resultData.Year);
        }

        [Fact]
        public async Task GetMovieDetailAsync_ShouldReturnNotFoundResponse_WhenIdIsInvalid()
        {
            //Arrange
            Type expectedStatus = typeof(NotFoundObjectResult);

            _movieServices.Setup(x => x.GetMovieByIdAsync(122)).Throws<ArgumentException>();

            //Act
            ActionResult<MovieDetailsDto> result = await _movieController!.GetMovieDetailAsync(122);

            //Assert           
            Type resultStatus = result.Result!.GetType();

            Assert.Equal(expectedStatus, resultStatus);
        }
    }
}