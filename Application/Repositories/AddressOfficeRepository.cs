using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class AddressOfficeRepository : GenericRepository<AddressOffice>, IAddressOffice
    {
        private readonly BioseguridadContext _context;

        public AddressOfficeRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}