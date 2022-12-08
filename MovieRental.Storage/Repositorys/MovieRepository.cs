﻿using Microsoft.EntityFrameworkCore;
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
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(IMovieRentalDbContext movieRentalDbContext) : base(movieRentalDbContext)
        {
        }

        public async Task<IReadOnlyCollection<Movie>> GetAllMoviesAsync()
        {
           return await GetAll().ToArrayAsync();
        }

        public void AddMovie(Movie movie)
        {
            AddItem(movie);
        }

        public void DeletMovie(Movie movie)
        {
            RemoveItem(movie);
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await GetItemById(id).FirstOrDefaultAsync() ?? throw new NullReferenceException();
        }
    }
}