using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract.DTOs.Director
{
    public class CreateDirectorDto
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(20,MinimumLength = 2)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string? Image_Url { get; set; }
    }
}
