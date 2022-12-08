using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MovieRental.Contract;
using MovieRental.Contract.DTOs;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Services.Mapper;
using MovieRental.Shered;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieRental.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        private readonly IUnitOfWork _unitOfWork;

        private IOptions<Auth> _options;

        public UserServices(IUserRepository userRepository, IUnitOfWork unitOfWork, IOptions<Auth> options)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _options = options;
        }

        public async Task<IReadOnlyCollection<UserDetailsDto>> GetAllUsersAsync()
        {
            IReadOnlyCollection<User> users = await _userRepository.GetAllUserAsync();

            return users.Select(user => user.ToUserDetailsDto()).ToArray();
        }

        public async Task RegisterUserAsync(CreateUserDto Newuser)
        {
            User user = new();

            user.UserName = Newuser.UserName;
            user.Password = Newuser.Password;
            user.FirstName = Newuser.FirstName;
            user.LastName = Newuser.LastName;

            _userRepository.AddUser(user);

            await _unitOfWork.SavaChangesAsync();
        }

        public async Task<string> LoginUserAsync(LoginUserDto user)
        {
            User getUser = await _userRepository.GetUserByUsernameAsync(user.UserName);


            if(getUser is null || getUser.Password != user.Password)
            {
                throw new Exception("Invalid password or username");
            }


            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            byte[] secretKeyBytes = Encoding.ASCII.GetBytes(_options.Value.Key!);

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(3), 

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                    SecurityAlgorithms.HmacSha256Signature),

                Subject = new ClaimsIdentity(
                    new[]
                   {
                        new Claim(ClaimTypes.Name, getUser.UserName!),
                        new Claim(ClaimTypes.NameIdentifier, getUser.Id.ToString()),
                        new Claim("userFullName", $"{getUser.FirstName} {getUser.LastName}"),
                        new Claim(ClaimTypes.Role, getUser.RoleType.ToString())
                    }
                )
            };

            SecurityToken token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            return jwtSecurityTokenHandler.WriteToken(token);
        }

        public void RemoveUse(User user)
        {
            throw new NotImplementedException();
        }
    }
}
