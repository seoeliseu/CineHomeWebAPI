using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineHome.Api.Domain.Entities;
using CineHome.Api.Domain.Interfaces;
using CineHome.Api.Domain.Interfaces.Services.Movie;

namespace CineHome.Api.Service.Services
{
    public class MovieService : IMovieService
    {
        private IRepository<MovieEntity> _repository;
        public MovieService(IRepository<MovieEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<MovieEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<MovieEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<MovieEntity> Post(MovieEntity movie)
        {
            return await _repository.InsertAsync(movie);
        }

        public async Task<MovieEntity> Put(MovieEntity movie)
        {
            return await _repository.UpdateAsync(movie);
        }
    }
}
