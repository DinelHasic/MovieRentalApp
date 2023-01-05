using Moq;
using MovieRental.Contract;
using MovieRental.Contract.DTOs.Direcor;
using MovieRental.Contract.DTOs.Genre;
using MovieRental.Contract.DTOs.Movie;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MovieRental.UnitTesting
{
    public class MovieServicesTest
    {
        private readonly Mock<IMovieRepository> _movieRepository = new Mock<IMovieRepository>();

        private readonly Mock<IUnitOfWork> _unitOfWork = new Mock<IUnitOfWork>();

        private readonly Mock<IDirectorRepository> _directoryRepository = new Mock<IDirectorRepository>();

        private readonly Mock<IGenreRepository> _genreRepository = new Mock<IGenreRepository>();

        private readonly MovieServices _movieServices;

        public MovieServicesTest()
        {
            _movieServices = new MovieServices(_movieRepository.Object, _unitOfWork.Object, _directoryRepository.Object, _genreRepository.Object);
        }

        [Fact]
        public async Task AddNewMovieAsync_SavesTheNewMovie()
        {
            //Arrange
            MovieCreateDto movieCreateDto = new()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = new List<int>() { 1, 2, 3 },
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<int>() { 1 },
                Year = new DateTime(2008, 2, 12)
            };

            IReadOnlyList<Director> directors = new List<Director>()
            {
                new Director(1, "Steven", "Spielberg", "https://upload.wikimedia.org/wikipedia/commons/6/67/Steven_Spielberg_by_Gage_Skidmore.jpg")
            };

            IReadOnlyCollection<Genre> genres = new List<Genre>()
            {
                 new Genre(1,"Drama"),
                 new Genre(2,"Comedy"),
                 new Genre(3,"Action"),
            };

            _directoryRepository.Setup(x => x.GetDirectorByIdsAsync(movieCreateDto.Directors))
            .ReturnsAsync(directors);

            _genreRepository.Setup(x => x.GetGenresByIdsAsync(movieCreateDto.Genres))
            .ReturnsAsync(genres);

            _unitOfWork.Setup(x => x.SavaChangesAsync());

            //Acct

            _movieServices.AddNewMovieAsync(movieCreateDto);

            //Assert
            _unitOfWork.Verify(x => x.SavaChangesAsync(), Times.AtLeastOnce());
        }

        [Fact]
        public async Task AddNewMovieAsync_ShuldThrowNullException_WhenDirectorsIsNull()
        {
            //Arange

            MovieCreateDto movieCreateDto = new()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = new List<int>() { 1, 2, 3 },
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = null,
                Year = new DateTime(2008, 2, 12)
            };

            //Assert
            var exception = Assert.ThrowsAsync<NullReferenceException>(() => _movieServices.AddNewMovieAsync(movieCreateDto));

            Assert.Equal(typeof(NullReferenceException), exception.Result.GetType());
        }

        [Fact]
        public async Task AddNewMovieAsync_ShuldThrowNullException_WhenGenresIsNull()
        {
            //Arange

            MovieCreateDto movieCreateDto = new()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = null,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<int>() { 1 },
                Year = new DateTime(2008, 2, 12)
            };

            //Assert
            var exception = Assert.ThrowsAsync<NullReferenceException>(() => _movieServices.AddNewMovieAsync(movieCreateDto));

            Assert.Equal(typeof(NullReferenceException), exception.Result.GetType());
        }

        [Fact]
        public async Task AddNewMovieAsync_ShuldThrowException_WhenDirectorsIdsAreInvalid()
        {
            //Arange
            MovieCreateDto movieCreateDto = new()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = new List<int>() { 1, 2, 3 },
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<int>() { 122 },
                Year = new DateTime(2008, 2, 12)
            };

            _directoryRepository.Setup(x => x.GetDirectorByIdsAsync(movieCreateDto.Directors)).ReturnsAsync(new List<Director>());

            //Assert
            var exception = Assert.ThrowsAsync<InvalidOperationException>(() => _movieServices.AddNewMovieAsync(movieCreateDto));

            Assert.Equal(typeof(InvalidOperationException), exception.Result.GetType());
        }

        [Fact]
        public async Task AddNewMovieAsync_ShuldThrowException_WhenGenresIdsAreInvalid()
        {
            //Arange
            MovieCreateDto movieCreateDto = new()
            {
                Title = "Scooy Doo",
                Description = "Scooby Do goes to hawai",
                Genres = new List<int>() { 122, 222, 311 },
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTJkOGM1MDUtZTkxOS00MmYxLTk2ZWYtMTQzZmMyOWI3ODgzXkEyXkFqcGdeQXVyNDQ5MDYzMTk@._V1_FMjpg_UX1000_.jpg",
                Directors = new List<int>() { 1 },
                Year = new DateTime(2008, 2, 12)
            };

            IReadOnlyList<Director> directors = new List<Director>()
            {
                new Director(1, "Steven", "Spielberg", "https://upload.wikimedia.org/wikipedia/commons/6/67/Steven_Spielberg_by_Gage_Skidmore.jpg")
            };

            _directoryRepository.Setup(x => x.GetDirectorByIdsAsync(movieCreateDto.Directors)).ReturnsAsync(directors);

            _genreRepository.Setup(x => x.GetGenresByIdsAsync(movieCreateDto.Genres)).ReturnsAsync(new List<Genre>());

            //Assert
            var exception = Assert.ThrowsAsync<InvalidOperationException>(() => _movieServices.AddNewMovieAsync(movieCreateDto));

            Assert.Equal(typeof(InvalidOperationException), exception.Result.GetType());
        }
    }
}

