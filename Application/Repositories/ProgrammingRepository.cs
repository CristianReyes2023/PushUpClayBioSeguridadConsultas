using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ProgrammingRepository : GenericRepository<Programming>, IProgramming
    {
        private readonly BioseguridadContext _context;

        public ProgrammingRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}