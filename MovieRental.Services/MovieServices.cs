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

           if (newMovie.Directors is null || newMovie.Genres is null)
           {
                 throw new NullReferenceException("Invalid inputs");
           }

           IReadOnlyCollection<Director> directors = await _directorRepository.GetDirectorByIdsAsync(newMovie.Directors);

           if (directors.Count() == 0)
           {
               throw new InvalidOperationException("Directors not found");
           }

           IReadOnlyCollection<Genre> genres = await _genreRepository.GetGenresByIdsAsync(newMovie.Genres);

           if (genres.Count() == 0)
           {
               throw new InvalidOperationException("Genre not found");
           }

           Movie movie = new()
           {
             Title = newMovie.Title,
             Description = newMovie.Description,
             Genres = genres.ToArray(),
             ImageUrl = newMovie.ImageUrl,
             Year = newMovie.Year,
             Directors = directors.ToArray(),
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
            Movie movie = await _movieRepository.GetMovieByIdAsync(id) ?? throw new ArgumentException("Movie not found");

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
