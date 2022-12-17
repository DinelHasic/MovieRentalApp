using MovieRental.Domain.Enteties;
using MovieRental.Domain.Repository;
using MovieRental.Storage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Storage.Repositorys
{
    public class GenreRepository : BaseRepository<Genre>,IGenreRepository
    {
        public GenreRepository(IMovieRentalDbContext movieRentalDbContext) : base(movieRentalDbContext)
        {
        }

        public IReadOnlyCollection<Genre> GetGenresByIds(List<int> ids)
        {
            return GetAll().Where(x => ids.Contains(x.Id)).ToArray();
        }
    }
}
