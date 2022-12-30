using MovieRental.Domain.Enteties;
using MovieRental.Domain.Enum;
using MovieRental.Storage.Helper;

namespace MovieRental.Storage.Seed
{
    internal static class UserSeed
    {
        public readonly static List<User> USERS = new()
        {
            new User(1, "Dinko", HashingPassword.GetHashedPassword("Lord123"), "DinkoTest", "Dinko123", Role.Admin),
            new User(2, "Vanja", HashingPassword.GetHashedPassword("Vanja123"), "VanjaTest", "Vanja123", Role.User),
            new User(3, "Cvetan",HashingPassword.GetHashedPassword("Cvetan123"), "CvetanTest", "Cvetan123", Role.User),
            new User(4, "Miki", HashingPassword.GetHashedPassword("Miki123"), "MikiTest", "Miki123", Role.User)
        };

    }
}
