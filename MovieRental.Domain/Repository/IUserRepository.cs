using MovieRental.Domain.Enteties;

namespace MovieRental.Domain.Repository
{
    public interface IUserRepository
    {
        Task<IReadOnlyCollection<User>> GetAllUserAsync();

        void AddUser(User user);

        void RemoveUser(User user);
       Task<User> GetUserByUsernameAsync(string? userName);
    }
}
