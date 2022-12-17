using MovieRental.Domain.Enum;

namespace MovieRental.Domain.Enteties
{
    public class Movie : BaseEntity
    { 
        public string? Title { get; set; }

        public string? Description { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public DateTime Year { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<User>? User { get; set; }

        public ICollection<Director>? Directors { get; set; }

        public ICollection<Rating> Rating { get; set; }

        public Movie()
        {

        }

        public Movie(int id,string? title, string? description, DateTime year,string imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            Year = year;
            ImageUrl = imageUrl;
        }
    }
}
