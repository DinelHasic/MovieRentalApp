using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Storage.Database.Seed
{
    internal static class RatingSeed
    {
        public static List<Rating> RATINGS = new()
        {
            new Rating(1,9,1),
            new Rating(2,10,1),
            new Rating(3,8,2),
            new Rating(4,8,2),
            new Rating(5,10,3),
            new Rating(6,9,3),
            new Rating(7,8,4),
            new Rating(8,8,5),
            new Rating(9,9,6),
            new Rating(10,6,7),
            new Rating(11,9,7),
            new Rating(12,8,8),
            new Rating(13,7,8),
            new Rating(14,5,8),
            new Rating(15,10,9),
            new Rating(16,5,9),
            new Rating(17,8,10),
            new Rating(18,9,10),
        };
    }
}
