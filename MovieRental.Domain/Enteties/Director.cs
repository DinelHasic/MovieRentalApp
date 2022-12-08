namespace MovieRental.Domain.Enteties
{
    public class Director : BaseEntity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public List<Movie>? ListMovies { get; set; }

        public int ListMoviesId { get; set; }

        public Director(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}