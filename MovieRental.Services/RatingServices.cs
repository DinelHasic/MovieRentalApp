using MovieRental.Contract;
using MovieRental.Contract.DTOs.Rating;
using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services
{
    public class RatingServices : IRatingServices
    {
        private readonly IRatingRepository _ratingRepository;

        private readonly IMovieRepository _movieRepository;

        private readonly IUnitOfWork _unitOfWork;

        public RatingServices(IRatingRepository ratingRepository, IMovieRepository movieRepository, IUnitOfWork unitOfWork)
        {
            _ratingRepository = ratingRepository;
            _movieRepository = movieRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddRatingAsync(CreateReatingDto rating)
        {
           Movie movie =  await _movieRepository.GetMovieByIdAsync(rating.MovieId) ?? throw new Exception("Movie not found");

           Rating newRating = new Rating()
           {
                RatingNumber = rating.RatingNumber,
                Movie = movie
           };

           _ratingRepository.AddRating(newRating);

           await _unitOfWork.SavaChangesAsync();
        }
    }
}
