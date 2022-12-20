using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IGenreRepository
    {
        Task<IReadOnlyCollection<Genre>> ReturnAllGenresAsync();
        Task<IReadOnlyCollection<Genre>> GetGenresByIdsAsync(List<int> ids);
    }
}
