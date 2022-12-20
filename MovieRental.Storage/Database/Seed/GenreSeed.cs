using MovieRental.Domain.Enteties;

namespace MovieRental.Storage.Database.Seed
{
    internal static class GenreSeed
    {
        public static List<Genre> GENRES = new()
        {
            new Genre(1,"Drama"),
            new Genre(2,"Comedy"),
            new Genre(3,"Action"),
            new Genre(4,"Fantasy"),
            new Genre(5,"Horror"),
            new Genre(6,"Romance"),
            new Genre(7,"Western"),
            new Genre(8,"Thriller"),
            new Genre(9,"Animation")
        };
    }
}
