using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Application.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Domain.Employee>> Get();
        Task<Domain.Employee> Get(int id);
    }
}
