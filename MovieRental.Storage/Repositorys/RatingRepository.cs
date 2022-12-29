using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Storage.Repositorys
{
    public class RatingRepository : BaseRepository<Rating>,IRatingRepository
    {
        public RatingRepository(IMovieRentalDbContext movieRentalDbContext) : base(movieRentalDbContext)
        {
        }

        public void AddRating(Rating rating)
        {
            AddItem(rating);
        }
    }
}
