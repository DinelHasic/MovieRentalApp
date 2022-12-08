using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieRental.Contract;
using MovieRental.Contract.DTOs;

namespace MovieRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("user/register")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterUserAsync(CreateUserDto user)
        {
           await _userServices.RegisterUserAsync(user);

            return Ok(user);
        }

        [HttpGet("user/get/all/users")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<UserDetailsDto>>> GetUserDetails()
        {
          IEnumerable<UserDetailsDto> users =  await _userServices.GetAllUsersAsync();

          return Ok(users);
        }

        [HttpPost("user/login")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> LoginUser(LoginUserDto user)
        {
            try
            {
              string userAuth = await _userServices.LoginUserAsync(user);

               return Ok(userAuth);
            }
            catch (Exception ex)
            {
               return Unauthorized(ex.Message);
            }
        }

    }           
}
