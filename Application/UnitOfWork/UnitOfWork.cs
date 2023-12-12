using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;


namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly BioseguridadContext _context;

        public UnitOfWork(BioseguridadContext context)
        {
            _context = context;
        }

        private IAddressclient _addressClient;
        private IAddressoffice _addressOffice;
        private ICity _cities;
        private IClient _client;
        private IContract _contract;
        private ICountry _countries;
        private IEmployee _employee;
        private IPosition _position;
        private IProgramming _programming;
        private IState _state;
        private IStateContract _stateContract;
        private ITurn _turn;
        private ITypeperson _typePerson;

        public IAddressclient Addressclients
        {
            get
            {
                if (_addressClient == null)
                {
                    _addressClient = new AddressClientRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _addressClient;
            }
        }
        public IAddressoffice Addressoffices
        {
            get
            {
                if (_addressOffice == null)
                {
                    _addressOffice = new AddressOfficeRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _addressOffice;
            }
        }
        public ICity Cities
        {
            get
            {
                if (_cities == null)
                {
                    _cities = new CityRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _cities;
            }
        }
        public IClient Clients
        {
            get
            {
                if (_client == null)
                {
                    _client = new ClientRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _client;
            }
        }
        public IContract Contracts
        {
            get
            {
                if (_contract == null)
                {
                    _contract = new ContractRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _contract;
            }
        }
        public ICountry Countries
        {
            get
            {
                if (_countries == null)
                {
                    _countries = new CountryRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _countries;
            }
        }
        public IEmployee Employees
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _employee;
            }
        }
        public IPosition Positions
        {
            get
            {
                if (_position == null)
                {
                    _position = new PositionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _position;
            }
        }
        public IProgramming Programmings
        {
            get
            {
                if (_programming == null)
                {
                    _programming = new ProgrammingRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _programming;
            }
        }
        public IState States
        {
            get
            {
                if (_state == null)
                {
                    _state = new StateRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _state;
            }
        }
        public ITurn Turns
        {
            get
            {
                if (_turn == null)
                {
                    _turn = new TurnRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _turn;
            }
        }
        public ITypeperson TypePersons
        {
            get
            {
                if (_typePerson == null)
                {
                    _typePerson = new TypePersonRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _typePerson;
            }
        }
        public IStateContract StateContracts
        {
            get
            {
                if (_stateContract == null)
                {
                    _stateContract = new StateContractRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _stateContract;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}