using MovieRental.Domain.Repository;
using MovieRental.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Storage.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMovieRentalDbContext _movieRentalDbContext;

        public UnitOfWork(IMovieRentalDbContext movieRentalDbContext)
        {
            _movieRentalDbContext = movieRentalDbContext;
        }

        public async Task<int> SavaChangesAsync()
        {
            if (_movieRentalDbContext.ChangeTracker.HasChanges())
            {
                return await _movieRentalDbContext.SaveChangesAsync(); 
            }

            return 0;
        }
    }
}
