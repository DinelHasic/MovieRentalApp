using MovieRental.Contract.ValidateAtribute;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Contract.DTOs
{
    public class CreateUserDto
    {
        [StringLength(15,MinimumLength = 5)]
        [UsernameValidation(ErrorMessage = "Username has to be at least five characters and to strat with uppercase letter")]
        public string? UserName { get; set; }

        [StringLength(20, MinimumLength = 7)]
        [PasswordValidation(ErrorMessage = "Password hast to be  at least seven characters to contain one number , uppercase and lowelcase letter")]
        public string? Password { get; set; }

        [StringLength(15, MinimumLength = 3,ErrorMessage = "First Name has to be at least three characters")]
        public string? FirstName { get; set; }

        [StringLength(15, MinimumLength = 3,ErrorMessage = "Last Name has to be at least three characters")]
        public string? LastName { get; set; }
    }
}
