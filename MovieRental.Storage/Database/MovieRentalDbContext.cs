using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Enteties;
using MovieRental.Storage.Database.Seed;
using MovieRental.Storage.Extension;
using MovieRental.Storage.Seed;

namespace MovieRental.Storage.Database
{
    public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {
        public DbSet<Movie>? Movies { get; set; }

        public DbSet<User>? Users { get; set; }

        public DbSet<Director>? Directors { get; set; }

        public DbSet<Genre>? Genres { get; set; }

        public DbSet<Rating>? Ratings { get; set; }

        public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(MovieSeed.MOVIES);
            modelBuilder.Entity<User>().HasData(UserSeed.USERS);
            modelBuilder.Entity<Director>().HasData(DirectorSeed.DIRECTORS);
            modelBuilder.Entity<Genre>().HasData(GenreSeed.GENRES);
            modelBuilder.Entity<Rating>().HasData(RatingSeed.RATINGS);

            modelBuilder.Entity<Rating>()
            .HasOne(x => x.Movie)
            .WithMany(x => x.Rating)
            .HasForeignKey(x => x.MovieId);

            modelBuilder.RealationDirecorMovie();
            modelBuilder.RealationUserMovie();
            modelBuilder.RelationGenreMovie();
        }
    }
}
