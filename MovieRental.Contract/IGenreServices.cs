using MovieRental.Contract.DTOs.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract
{
    public interface IGenreServices
    {
        Task<IReadOnlyCollection<GenreDto>> GetAllGenresAsync();
    }
}
