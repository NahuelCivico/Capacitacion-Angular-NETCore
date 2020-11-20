using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todo.Application.Interfaces
{
    public interface ICategoryService
    {
        Task Add(Domain.Category category);
        Task Update(Domain.Category category);
        Task Delete(int id);
        Task<List<Domain.Category>> Get();
        Task<Domain.Category> Get(int id);
    }
}
