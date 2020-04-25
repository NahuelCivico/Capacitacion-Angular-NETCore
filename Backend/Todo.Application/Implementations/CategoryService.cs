using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Interfaces;
using Todo.Application.Repositories;
using Todo.Domain;

namespace Todo.Application.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Add(Category category)
        {
            await _categoryRepository.Add(category);
            await _categoryRepository.SaveChanges();
        }

        public async Task Delete(int id)
        {
            await _categoryRepository.Delete(id);
            await _categoryRepository.SaveChanges();
        }

        public Task<List<Category>> Get()
        {
            return _categoryRepository.Get();
        }

        public Task<Category> Get(int id)
        {
            return _categoryRepository.Get(id);
        }
        public async Task Update(Category category)
        {
            _categoryRepository.Update(category);
            await _categoryRepository.SaveChanges();
        }
    }
}
