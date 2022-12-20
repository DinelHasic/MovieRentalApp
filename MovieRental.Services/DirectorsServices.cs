using MovieRental.Contract;
using MovieRental.Contract.DTOs.Director;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Services.Mapper;

namespace MovieRental.Services
{
    public class DirectorsServices : IDirectorServices
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorsServices(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public async Task<IReadOnlyCollection<DirectorSelectionDto>> GetAllDirectorsAsync()
        {
          IReadOnlyCollection<Director> directors =  await _directorRepository.GetAllDirectorsAsync();

          return directors.Select(x => x.ToDirectorSelectionDto()).ToArray();
        }
    }
}
