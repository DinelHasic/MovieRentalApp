using MovieRental.Domain.Enteties;
using MovieRental.Domain.Enum;

namespace MovieRental.Storage.Seed
{
    internal static class UserSeed
    {
        public readonly static List<User> USERS = new()
        {
          new User(1,"Dinko", "Lord", "DinkoTest", "Dinko123",Role.Admin),
          new User(2,"Vanja", "Vanja1", "VanjaTest", "Vanja123",Role.User),
          new User(3,"Cvetan", "Cvetan", "CvetanTest", "Cvetan123", Role.User),
          new User(4,"Miki", "Miki", "MikiTest", "Miki123", Role.User)
        };
    }
}
