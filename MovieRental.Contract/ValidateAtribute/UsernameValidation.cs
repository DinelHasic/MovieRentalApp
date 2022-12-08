using System.ComponentModel.DataAnnotations;


namespace MovieRental.Contract.ValidateAtribute
{
    internal class UsernameValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null)
            {
                return false;
            }

            string username = value.ToString()!;

            bool isUpper = char.IsUpper(username.First());

            if (!isUpper)
            {
                return false;
            }

            return true;
        }
    }
}
