using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todo.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Domain.Employee>> Get();
        Task<Domain.Employee> Get(int id);
    }
}
