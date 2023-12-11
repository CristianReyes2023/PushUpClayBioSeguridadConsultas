using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ContractRepository : GenericRepository<Contract>, IContract
    {
        private readonly BioseguridadContext _context;

        public ContractRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}