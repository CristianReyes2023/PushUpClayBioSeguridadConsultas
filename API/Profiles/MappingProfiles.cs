using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AddressClient,AddressClientDto>().ReverseMap();
        CreateMap<AddressOffice, AddressOfficeDto>().ReverseMap();
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Client, ClientDto>().ReverseMap();
        CreateMap<Contract, ContractDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<Position, PositionDto>().ReverseMap();
        CreateMap<Programming, ProgrammingDto>().ReverseMap();
        CreateMap<StateContract, StateContractDto>().ReverseMap();
        CreateMap<State, StateDto>().ReverseMap();
        CreateMap<Turn, TurnDto>().ReverseMap();
        CreateMap<TypePerson, TypePersonDto>().ReverseMap();
    }
}
