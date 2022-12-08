using MovieRental.Contract.ValidateAtribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract.DTOs
{
    public class LoginUserDto
    {
        
        public string? UserName { get; set; }

       
        public string? Password { get; set; }

    }
}
