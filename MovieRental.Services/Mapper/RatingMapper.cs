using MovieRental.Contract.DTOs;
using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services.Mapper
{
    public static class RatingMapper
    {
        public static RatingDto ToRatingDto(this Rating rating )
        {
            return new RatingDto()
            {
                RatingNumber = rating.RatingNumber
            };
        }

        public static double RatingCalculate(this ICollection<Rating> ratings)
        {
            if(ratings.Count == 0)
            {
                return 0;
            }


            double rating = ratings.Select(r => r.RatingNumber).Average();

            return  rating;
        }
    }
}
