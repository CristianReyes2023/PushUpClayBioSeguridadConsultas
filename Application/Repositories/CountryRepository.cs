using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountry
    {
        private readonly BioseguridadContext _context;

        public CountryRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}