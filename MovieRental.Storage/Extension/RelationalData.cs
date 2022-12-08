using Microsoft.EntityFrameworkCore;

namespace MovieRental.Storage.Extension
{
    internal static class RelationalData
    {
        public static void RealationDirecorMovie(this ModelBuilder builder)
        {
            builder.SharedTypeEntity<Dictionary<string, object>>("DirectorMovie")
                .HasData(
                 new { DirectorsId = 1, ListMoviesId = 1 },
                 new { DirectorsId = 2, ListMoviesId = 2 },
                 new { DirectorsId = 3, ListMoviesId = 3 },
                 new { DirectorsId = 4, ListMoviesId = 4 }
            );
        }

        public static void RealationUserMovie(this ModelBuilder builder)
        {
            builder.SharedTypeEntity<Dictionary<string, object>>("MovieUser")
                .HasData(
                new { UserId = 1, RentedMoviesId = 1 },
                new { UserId = 1, RentedMoviesId = 2 },
                new { UserId = 2, RentedMoviesId = 3 },
                new { UserId = 2, RentedMoviesId = 2 },
                new { UserId = 3, RentedMoviesId = 4 },
                new { UserId = 4, RentedMoviesId = 1 }
            );
        }
    }
}
