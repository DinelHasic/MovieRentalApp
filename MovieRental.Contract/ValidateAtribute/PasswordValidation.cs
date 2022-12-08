using System.ComponentModel.DataAnnotations;

namespace MovieRental.Contract.ValidateAtribute
{
    internal class PasswordValidation : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return false;
            }

            string? password = value.ToString();

            bool isNumber = password!.Any(x => char.IsDigit(x));

            bool isUpper = password!.Any(x => char.IsUpper(x));

            bool isLowe = password!.Any(x => char.IsLower(x));

            if (!(isNumber && isLowe && isUpper))
            {
                return false;
            }

            return true;
        }
    }
}
