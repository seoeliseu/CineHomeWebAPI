using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineHome.Api.Domain.Entities;

namespace CineHome.Api.Domain.Interfaces.Services.Movie
{
    public interface IMovieService
    {
        Task<MovieEntity> Get(Guid id);
        Task<IEnumerable<MovieEntity>> GetAll();
        Task<MovieEntity> Post(MovieEntity movie);
        Task<MovieEntity> Put(MovieEntity movie);
        Task<bool> Delete(Guid id);
    }
}
