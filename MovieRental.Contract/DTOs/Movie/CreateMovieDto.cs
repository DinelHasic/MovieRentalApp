

using MovieRental.Contract.DTOs.Genre;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Contract.DTOs.Movie
{
    public class MovieCreateDto
    {
        [Required]
        public string? Title { get; set; }

        [StringLength(170, MinimumLength = 30)]
        public string? Description { get; set; }

        [Required]
        public DateTime Year { get; set; }

        [Required]
        public IEnumerable<GenreMoviesDto>? Genres { get; set; }

        [DataType(DataType.ImageUrl)]
        public string? ImageUrl { get; set; }
    }
}
