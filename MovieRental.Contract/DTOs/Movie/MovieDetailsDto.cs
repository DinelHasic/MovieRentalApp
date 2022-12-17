using MovieRental.Contract.DTOs.Direcor;
using MovieRental.Contract.DTOs.Genre;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract.DTOs.Movie
{
    public class MovieDetailsDto
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public IEnumerable<GenreMoviesDto>? Genres { get; set; }

        public DateTime Year { get; set; }

        public string? ImageUrl { get; set; }

        public IEnumerable<DirectorDto>? Directors { get; set; }
    }
}
