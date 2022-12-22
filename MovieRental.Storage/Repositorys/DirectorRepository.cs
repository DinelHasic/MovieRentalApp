using Microsoft.EntityFrameworkCore;
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


        public async Task<IReadOnlyCollection<Director>> GetAllDirectorsAsync()
        {
            return await GetAll().ToArrayAsync();
        }

        public async Task<Director> GetDirectorByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(d => d.Id == id) ?? throw new NullReferenceException();
        }

        public async Task<IReadOnlyCollection<Director>> GetDirectorByIdsAsync(List<int> ids)
        {
            return  await GetAll().Where(x => ids.Contains(x.Id)).ToArrayAsync();
        }

        public void AddDirector(Director director)
        {
            AddItem(director);
        }
    }
}
