namespace MovieRental.Domain.Enteties
{
    public class Director : BaseEntity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Image_Url { get; set; }

        public List<Movie>? ListMovies { get; set; }

        public Director()
        {

        }
        public Director(int id ,string? firstName, string? lastName, string? image_Url)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Image_Url = image_Url;
        }
    }
}