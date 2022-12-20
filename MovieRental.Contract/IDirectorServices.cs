using MovieRental.Contract.DTOs.Director;

namespace MovieRental.Contract
{
    public interface IDirectorServices
    {
        Task<IReadOnlyCollection<DirectorSelectionDto>> GetAllDirectorsAsync();
    }
}
