using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Application.Repositories
{
    public interface ICategoryRepository
    {
        Task Add(Domain.Category category);
        void Update(Domain.Category category);
        Task Delete(int id);
        Task<List<Domain.Category>> Get();
        Task<Domain.Category> Get(int id);
        Task SaveChanges();
    }
}
