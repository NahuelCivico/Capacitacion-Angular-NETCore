using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Repositories;
using Todo.Data.Entities;
using Todo.Domain;

namespace Todo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TodoContext _ctx;
        private readonly IMapper _mapper;

        public CategoryRepository(TodoContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public async Task Add(Domain.Category category)
        {
            var categoryToAdd = _mapper.Map<Entities.Category>(category);

            await _ctx.AddAsync(categoryToAdd);
        }

        public async Task Delete(int id)
        {
            var categoryToDelete =  await _ctx.Categories.FindAsync(id);
            _ctx.Categories.Remove(categoryToDelete);
        }

        public async Task<List<Domain.Category>> Get()
        {
            var categoryList = await _ctx.Categories.ToListAsync();
            return _mapper.Map<List<Domain.Category>>(categoryList);
        }

        public async Task<Domain.Category> Get(int id)
        {
            var category = await _ctx.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<Domain.Category>(category);
        }

        public async Task SaveChanges()
        {
            await _ctx.SaveChangesAsync();
        }

        public void Update(Domain.Category category)
        {
            Entities.Category categoryUpdated = _mapper.Map<Entities.Category>(category);
            _ctx.Categories.Attach(categoryUpdated);
            _ctx.Entry(categoryUpdated).State = EntityState.Modified;
        }
    }
}
