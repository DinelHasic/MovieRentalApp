using MovieRental.Domain.Enteties;

namespace MovieRental.Storage.Seed
{
    internal static class DirectorSeed
    {
        public static List<Director> DIRECTORS = new()
        {
            new Director(1, "Steven", "Spielberg"),
            new Director(2, "Chris", "Columbus"),
            new Director(3, "Joe", "Johnston"),
            new Director(4, "Andrew", "Adamson"),
        };
    }
}
