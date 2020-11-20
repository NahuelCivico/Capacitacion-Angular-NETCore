using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Interfaces;
using Todo.Application.Repositories;
using Todo.Domain;

namespace Todo.Application.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<List<Employee>> Get()
        {
            return _employeeRepository.Get();
        }

        public Task<Employee> Get(int id)
        {
            return _employeeRepository.Get(id);
        }
    }
}
