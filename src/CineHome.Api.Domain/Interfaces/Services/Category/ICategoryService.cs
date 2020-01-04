using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineHome.Api.Domain.Entities;

namespace CineHome.Api.Domain.Interfaces.Services.Category
{
    public interface ICategoryService
    {
        Task<CategoryEntity> Get(Guid id);
        Task<IEnumerable<CategoryEntity>> GetAll();
        Task<CategoryEntity> Post(CategoryEntity movie);
        Task<CategoryEntity> Put(CategoryEntity movie);
        Task<bool> Delete(Guid id);
    }
}
