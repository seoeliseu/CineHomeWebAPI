using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CineHome.Api.Domain.Dtos.Movie;
using CineHome.Api.Domain.Entities;
using CineHome.Api.Domain.Interfaces;
using CineHome.Api.Domain.Interfaces.Services.Movie;
using CineHome.Api.Domain.Models;

namespace CineHome.Api.Service.Services
{
    public class MovieService : IMovieService
    {
        private IRepository<MovieEntity> _repository;
        private readonly IMapper _mapper;
        public MovieService(IRepository<MovieEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<MovieDtoResult> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<MovieDtoResult>(entity);
        }

        public async Task<IEnumerable<MovieDtoResult>> GetAll()
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<MovieDtoResult>>(entities);
        }

        public async Task<MovieDtoResult> Post(MovieDtoCreate movie)
        {
            var model = _mapper.Map<MovieModel>(movie);
            var entity = _mapper.Map<MovieEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<MovieDtoResult>(result);
        }

        public async Task<MovieDtoResult> Put(MovieDtoUpdate movie)
        {
            var model = _mapper.Map<MovieModel>(movie);
            var entity = _mapper.Map<MovieEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<MovieDtoResult>(result);
        }
    }
}
