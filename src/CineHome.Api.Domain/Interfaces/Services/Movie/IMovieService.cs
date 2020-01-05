using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineHome.Api.Domain.Dtos.Movie;
using CineHome.Api.Domain.Entities;

namespace CineHome.Api.Domain.Interfaces.Services.Movie
{
    public interface IMovieService
    {
        Task<MovieDtoResult> Get(Guid id);
        Task<IEnumerable<MovieDtoResult>> GetAll();
        Task<MovieDtoResult> Post(MovieDtoCreate movie);
        Task<MovieDtoResult> Put(MovieDtoUpdate movie);
        Task<bool> Delete(Guid id);
    }
}
