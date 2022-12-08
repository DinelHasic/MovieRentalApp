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

        public Genre Genre { get; set; }

        public DateTime Year { get; set; }

        public string? ImageUrl { get; set; }
    }
}
