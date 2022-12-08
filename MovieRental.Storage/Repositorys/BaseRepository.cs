using MovieRental.Domain.Enteties;
using MovieRental.Storage.Database;

namespace MovieRental.Storage.Repositorys
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        private readonly IMovieRentalDbContext _movieRentalDbContext;

        public BaseRepository(IMovieRentalDbContext movieRentalDbContext)
        {
            _movieRentalDbContext = movieRentalDbContext;
        }


        public IQueryable<T> GetAll()
        {
            return _movieRentalDbContext.Set<T>();
        }

        public void RemoveItem(T item)
        {
            _movieRentalDbContext.Set<T>().Remove(item);
        }

        public void AddItem(T item)
        {
            _movieRentalDbContext.Set<T>().Add(item);
        }

        public IQueryable<T> GetItemById(int id)
        {
            return _movieRentalDbContext.Set<T>().Where(x => x.Id == id) ?? throw new Exception();
        }
    }
}
