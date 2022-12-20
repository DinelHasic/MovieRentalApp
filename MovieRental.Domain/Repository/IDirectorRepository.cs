using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IDirectorRepository
    {
        Task<IReadOnlyCollection<Director>> GetAllDirectorsAsync();

        Task<Director> GetDirectorByIdAsync(int id);

        Task<IReadOnlyCollection<Director>> GetDirectorByIdsAsync(List<int> ids);
    }
}
