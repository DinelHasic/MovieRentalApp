using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IDirectorRepository
    {
        Director GetDirectorById(int id);

        IReadOnlyCollection<Director> GetDirectorByIds(List<int> ids);
    }
}
