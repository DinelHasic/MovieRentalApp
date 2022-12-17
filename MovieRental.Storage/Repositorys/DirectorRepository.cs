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
    public class DirectorRepository : BaseRepository<Director>,IDirectorRepository
    {
        public DirectorRepository(IMovieRentalDbContext movieRentalDbContext) : base(movieRentalDbContext)
        {
        }


        public Director GetDirectorById(int id)
        {
            return GetAll().FirstOrDefault(d => d.Id == id);
        }

        public IReadOnlyCollection<Director> GetDirectorByIds(List<int> ids)
        {
            return GetAll().Where(x => ids.Contains(x.Id)).ToArray();
        }
    }
}
