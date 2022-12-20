using MovieRental.Contract;
using MovieRental.Contract.DTOs.Genre;
using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services.Mapper
{
    public static class GenreMapper
    {
        public static GenreDto ToGenreDto(this Genre genres)
        {
            return new GenreDto()
            {
                GenreId = genres.Id,
                GenreTitle = genres.Title,
            };
        }
    }
}
