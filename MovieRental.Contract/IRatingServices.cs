using MovieRental.Contract.DTOs.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contract
{
    public interface IRatingServices
    {
        Task AddRatingAsync(CreateReatingDto rating);
    }
}
