using System.ComponentModel.DataAnnotations;

namespace MovieRental.Contract.DTOs.Rating
{
    public class CreateReatingDto
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        [Range(1,10,ErrorMessage = "Rating has to be 1 - 10")]
        public int RatingNumber { get; set; }
    }
}
