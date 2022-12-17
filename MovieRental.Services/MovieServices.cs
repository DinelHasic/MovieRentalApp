using MovieRental.Contract;
using MovieRental.Contract.DTOs.Movie;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Services.Mapper;

namespace MovieRental.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository _movieRepository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IDirectorRepository _directorRepository;

        private readonly IGenreRepository _genreRepository;
        public MovieServices(IMovieRepository movieRepository,IUnitOfWork unitOfWork,IDirectorRepository directorRepository,IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _unitOfWork = unitOfWork;
            _directorRepository = directorRepository;
            _genreRepository = genreRepository;
        }

        public async Task AddNewMovieAsync(MovieCreateDto newMovie)
        {

            ICollection<Director> directors = _directorRepository.GetDirectorByIds(newMovie.Directors!).ToArray();

            ICollection<Genre> genres = _genreRepository.GetGenresByIds(newMovie.Genres!).ToArray();

            Movie movie = new()
            {
                Title = newMovie.Title,
                Description = newMovie.Description,
                Genres = genres,
                ImageUrl = newMovie.ImageUrl,
                Year = newMovie.Year,
                Directors = directors
            };

            _movieRepository.AddMovie(movie);

            await _unitOfWork.SavaChangesAsync();
        }

        public async Task<IReadOnlyCollection<MovieDto>> GetAllMoviesAsync()
        {
            IReadOnlyCollection<Movie> movies = await _movieRepository.GetAllMoviesAsync();

            return movies.Select(x => x.ToMovieDto()).ToList();
        }

        public async Task<MovieDetailsDto> GetMovieByIdAsync(int id)
        {
            Movie movie = await _movieRepository.GetMovieByIdAsync(id);

            return movie.ToMovieDetailsDto();
        }

        public async Task RemoveMovieByIdAsync(int id)
        {
            Movie movie =  await _movieRepository.GetMovieByIdAsync(id);

           _movieRepository.DeletMovie(movie);

           await _unitOfWork.SavaChangesAsync();
        }
    }
}
