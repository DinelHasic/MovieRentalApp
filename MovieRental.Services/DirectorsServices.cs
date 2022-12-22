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

        private readonly IUnitOfWork _unitOfWork;

        public DirectorsServices(IDirectorRepository directorRepository,IUnitOfWork unitOfWork)
        {
            _directorRepository = directorRepository;

            _unitOfWork = unitOfWork;   
        }

        public async Task AddNewDirector(CreateDirectorDto director)
        {
            Director directorNew = new()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Image_Url = director.Image_Url,
            };

            _directorRepository.AddDirector(directorNew);

            await _unitOfWork.SavaChangesAsync();
        }

        public async Task<IReadOnlyCollection<DirectorSelectionDto>> GetAllDirectorsAsync()
        {
          IReadOnlyCollection<Director> directors =  await _directorRepository.GetAllDirectorsAsync();

          return directors.Select(x => x.ToDirectorSelectionDto()).ToArray();
        }
    }
}
