using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class PositionRepository : GenericRepository<Position>, IPosition
    {
        private readonly BioseguridadContext _context;

        public PositionRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}