using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployee
    {
        private readonly BioseguridadContext _context;

        public EmployeeRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Object>> GetEmployees()
        {
        var results = await (from _employee in _context.Employees
                             select new
                             {
                                 NombreEmpleado = _employee.NameEmployee
                             }).ToListAsync();
        return results;
        }
    }
}