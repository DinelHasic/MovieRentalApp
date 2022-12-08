using MovieRental.Contract.DTOs;
using MovieRental.Domain.Enteties;

namespace MovieRental.Services.Mapper
{
    internal static class UserMapper
    {
        public static UserDetailsDto ToUserDetailsDto(this User user)
        {
            return new UserDetailsDto() 
            { 
                Id = user.Id,
                FirstName  = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
            };
        }
    }
}
