using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAddressClient AddressClients {get;}
        IAddressOffice AddressOffices {get;}
        ICity Cities {get;}
        IClient Clients {get;}
        IContract Contracts {get;}
        IEmployee Employees {get;}
        IPosition Positions {get;}
        IProgramming Programmings {get;}
        IState States {get;}
        ITurn Turns {get;}
        ITypePerson TypePersons {get;}

        Task<int> SaveAsync();
    }
}