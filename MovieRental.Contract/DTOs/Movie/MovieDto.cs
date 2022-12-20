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
    public class MovieDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public IEnumerable<GenreDto>? Genres { get; set; }

        public DateTime Year { get; set; }

        public string? ImageUrl { get; set; }


    }
}
