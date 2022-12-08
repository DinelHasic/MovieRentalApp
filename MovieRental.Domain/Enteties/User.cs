using MovieRental.Domain.Enum;

namespace MovieRental.Domain.Enteties
{
    public class User : BaseEntity
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public Genre? FovriteGenre { get; set; }

        public ICollection<Movie>? RentedMovies { get; set; }

        public int RentedMoviesId { get; set; }

        public Role  RoleType { get; set; }

        public User()
        {

        }

        public User(int id, string userName, string password, string firstName, string lastName,Role roleType)
        {
            Id = id;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            RoleType = roleType;
        }
    }
}