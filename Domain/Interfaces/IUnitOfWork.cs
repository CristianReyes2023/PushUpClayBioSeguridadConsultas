using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAddressclient Addressclients {get;}
        IAddressoffice Addressoffices {get;}
        ICity Cities {get;}
        IClient Clients {get;}
        ICountry Countries {get;}
        IContract Contracts {get;}
        IEmployee Employees {get;}
        IPosition Positions {get;}
        IProgramming Programmings {get;}
        IState States {get;}
        IStateContract StateContracts {get;}
        ITurn Turns {get;}
        ITypeperson TypePersons {get;}

        Task<int> SaveAsync();
    }
}