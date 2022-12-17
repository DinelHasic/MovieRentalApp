using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IGenreRepository
    {
        IReadOnlyCollection<Genre> GetGenresByIds(List<int> ids);
    }
}
