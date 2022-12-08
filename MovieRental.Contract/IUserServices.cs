using MovieRental.Contract.DTOs;
using MovieRental.Domain.Enteties;

namespace MovieRental.Contract
{
    public interface IUserServices
    {
        public Task<IReadOnlyCollection<UserDetailsDto>> GetAllUsersAsync();

        public Task RegisterUserAsync(CreateUserDto user);

        public void RemoveUse(User user);

        Task<string> LoginUserAsync(LoginUserDto user);
    }
}
