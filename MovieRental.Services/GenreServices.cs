using MovieRental.Contract;
using MovieRental.Contract.DTOs.Genre;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services
{
    public class GenreServices : IGenreServices
    {
        private readonly IGenreRepository _genreRepository;

        public GenreServices(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IReadOnlyCollection<GenreDto>> GetAllGenresAsync()
        {
            IReadOnlyCollection<Genre> genres = await _genreRepository.ReturnAllGenresAsync();

            return genres.Select(x => x.ToGenreDto()).ToArray();
   
        }
    }
}
