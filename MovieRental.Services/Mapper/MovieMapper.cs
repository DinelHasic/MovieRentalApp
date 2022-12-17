using MovieRental.Contract.DTOs.Genre;
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
                Genres = movie.Genres.Select(x => x.ToGenreMovie()),
                Description = movie.Description,
                Year = movie.Year,
                ImageUrl = movie.ImageUrl,
            };
        }

        public static GenreMoviesDto ToGenreMovie(this Genre genres)
        {
            return new GenreMoviesDto()
            {
                GenreId = genres.Id,
                GenreTitle = genres.Title,
            };
        }


        public static MovieDetailsDto ToMovieDetailsDto(this Movie movie)
        {
            return new MovieDetailsDto()
            {
                Title = movie.Title,
                Description = movie.Description,
                Genres = movie.Genres!.Select(x => x.ToGenreMovie()),
                Year = movie.Year,
                Rating = movie.Rating.RatingCalculate(),
                ImageUrl = movie.ImageUrl,
                Directors =  movie.Directors!.Select(x => x.ToDirectorDto())
            };
        }
    }
}
