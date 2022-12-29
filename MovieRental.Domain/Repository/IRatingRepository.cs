using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Domain.Repository
{
    public interface IRatingRepository
    {
        void AddRating(Rating rating);
    }
}
