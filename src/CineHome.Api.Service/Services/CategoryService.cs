using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineHome.Api.Domain.Entities;
using CineHome.Api.Domain.Interfaces;
using CineHome.Api.Domain.Interfaces.Services.Category;

namespace CineHome.Api.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<CategoryEntity> _repository;
        public CategoryService(IRepository<CategoryEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoryEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CategoryEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CategoryEntity> Post(CategoryEntity movie)
        {
            return await _repository.InsertAsync(movie);
        }

        public async Task<CategoryEntity> Put(CategoryEntity movie)
        {
            return await _repository.UpdateAsync(movie);
        }
    }
}
