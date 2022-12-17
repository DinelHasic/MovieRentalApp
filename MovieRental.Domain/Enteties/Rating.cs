using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Domain.Enteties
{
    public class Rating : BaseEntity
    { 
        public int RatingNumber { get; set; }

        [ForeignKey(nameof(MovieId))]
        public  Movie? Movie { get; set; }

        public int MovieId { get; set; }

        public Rating(int id,int ratingNumber,int movieId)
        {
            Id = id;
            RatingNumber = ratingNumber;
            MovieId = movieId;
        }
    }
}
