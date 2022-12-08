using MovieRental.Contract.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract
{
    public interface IMovieServices
    {
        Task<IReadOnlyCollection<MovieDto>> GetAllMoviesAsync();

        Task AddNewMovieAsync(MovieCreateDto newMovie);

        Task RemoveMovieByIdAsync(int id);

        Task<MovieDetailsDto> GetMovieByIdAsync(int id);
    }
}
