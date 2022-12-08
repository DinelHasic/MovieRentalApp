using MovieRental.Domain.Enum;

namespace MovieRental.Domain.Enteties
{
    public class Movie : BaseEntity
    { 
        public string? Title { get; set; }

        public string? Description { get; set; }

        public Genre Genre { get; set; }

        public DateTime Year { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<User>? User { get; set; }

        public ICollection<Director>? Directors { get; set; }

        public int UserId { get; set; }

        public int DirecorId { get; set; }

        public Movie()
        {

        }

        public Movie(int id,string? title, string? description, DateTime year,Genre genre,string imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            Genre = genre;
            Year = year;
            ImageUrl = imageUrl;
        }
    }
}
