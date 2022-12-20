using MovieRental.Contract.DTOs.Movie;
using MovieRental.Domain.Enteties;

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
                Genres = movie.Genres!.Select(x => x.ToGenreDto()),
                Description = movie.Description,
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
                Genres = movie.Genres!.Select(x => x.ToGenreDto()),
                Year = movie.Year,
                Rating = movie.Rating!.RatingCalculate(),
                ImageUrl = movie.ImageUrl,
                Directors = movie.Directors!.Select(x => x.ToDirectorDto())
            };
        }
    }
}
