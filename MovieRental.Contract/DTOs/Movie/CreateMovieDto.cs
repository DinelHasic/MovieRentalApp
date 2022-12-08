using MovieRental.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract.DTOs.Movie
{
    public class MovieCreateDto
    {
        [Required]
        public string? Title { get; set; }

        [StringLength(170,MinimumLength = 30)]
        public string? Description { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public DateTime Year { get; set; }

        [DataType(DataType.ImageUrl)]
        public string? ImageUrl { get; set; }
    }
}
