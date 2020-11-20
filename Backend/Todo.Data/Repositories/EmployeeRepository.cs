using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Application.Repositories;
using Todo.Domain;

namespace Todo.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TodoContext _ctx;
        private readonly IMapper _mapper;

        public EmployeeRepository(TodoContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<List<Employee>> Get()
        {
            var employeeList = await _ctx.Employees.ToListAsync();
            return _mapper.Map<List<Domain.Employee>>(employeeList);
        }

        public async Task<Employee> Get(int id)
        {
            var employee = await _ctx.Employees.FirstOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<Domain.Employee>(employee);
        }
    }
}
