using MovieRental.Contract.DTOs.Movie;
using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services.Mapper
{
    internal static class MovieMapper
    {
        public static MovieDto ToMovieDto(this Movie movie)
        {
            return new MovieDto()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Year = movie.Year,
                ImageUrl = movie.ImageUrl,
            };
        }


        public static MovieDetailsDto ToMovieDetailsDto(this Movie movie)
        {
            return new MovieDetailsDto()
            {
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Year = movie.Year,
                ImageUrl = movie.ImageUrl,
            };
        }
    }
}
