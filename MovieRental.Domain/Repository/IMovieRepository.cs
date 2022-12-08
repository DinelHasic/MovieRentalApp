using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IMovieRepository
    {
        Task<IReadOnlyCollection<Movie>> GetAllMoviesAsync();

        void AddMovie(Movie movie);

        void DeletMovie(Movie movie);

        Task<Movie> GetMovieByIdAsync(int id);
    }
}
