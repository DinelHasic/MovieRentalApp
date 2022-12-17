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
                 new { DirectorsId = 4, ListMoviesId = 4 },
                 new { DirectorsId = 5, ListMoviesId = 5 },
                 new { DirectorsId = 6, ListMoviesId = 6 },
                 new { DirectorsId = 7, ListMoviesId = 6 },
                 new { DirectorsId = 8, ListMoviesId = 7 },
                 new { DirectorsId = 9, ListMoviesId = 8 },
                 new { DirectorsId = 10,ListMoviesId= 9 },
                 new { DirectorsId = 2,ListMoviesId = 10 }




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

        public static void RelationGenreMovie(this ModelBuilder builder)
        {

            builder.SharedTypeEntity<Dictionary<string, object>>("GenreMovie")
                .HasData(
                new { GenresId = 1, MoviesId = 1 },
                new { GenresId = 2, MoviesId = 1 },
                new { GenresId = 2, MoviesId = 2 },
                new { GenresId = 2, MoviesId = 3 },
                new { GenresId = 4, MoviesId = 3 },
                new { GenresId = 1, MoviesId = 4 },
                new { GenresId = 4, MoviesId = 4 },
                new { GenresId = 9, MoviesId = 5 },
                new { GenresId = 9, MoviesId = 6 },
                new { GenresId = 9, MoviesId = 7 },
                new { GenresId = 2, MoviesId = 7 },
                new { GenresId = 4, MoviesId = 8 },
                new { GenresId = 3, MoviesId = 8 },
                new { GenresId = 1, MoviesId = 9 },
                new { GenresId = 2, MoviesId = 9 },
                new { GenresId = 4, MoviesId = 10 },
                new { GenresId = 2, MoviesId = 10 }
                );
        }
    }
}
