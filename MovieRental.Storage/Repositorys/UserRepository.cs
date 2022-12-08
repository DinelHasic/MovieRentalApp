using Microsoft.EntityFrameworkCore;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Storage.Database;

namespace MovieRental.Storage.Repositorys
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(IMovieRentalDbContext movieRentalDbContext) : base(movieRentalDbContext)
        {

        }
        public async Task<IReadOnlyCollection<User>> GetAllUserAsync()
        {
            return await GetAll().ToArrayAsync();
        }

        public void RemoveUser(User user)
        {
           RemoveItem(user);
        }

        public void AddUser(User user)
        {
            AddItem(user);
        }

        public User GetUserById(int id)
        {
            return GetItemById(id).FirstOrDefault() ?? throw new NullReferenceException(); 
        }

        public async Task<User> GetUserByUsernameAsync(string? userName)
        {
            return  await GetAll().SingleOrDefaultAsync(x => x.UserName == userName); 
        }
    }
}
