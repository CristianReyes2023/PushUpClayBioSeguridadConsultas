using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

public partial class BioseguridadContext : DbContext
{
    public BioseguridadContext()
    {
    }

    public BioseguridadContext(DbContextOptions<BioseguridadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressClient> Addressclients { get; set; }

    public virtual DbSet<AddressOffice> Addressoffices { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Programming> Programmings { get; set; }

    // public virtual DbSet<Refreshtoken> Refreshtokens { get; set; }

    // public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Statecontract> Statecontracts { get; set; }

    public virtual DbSet<Turn> Turns { get; set; }

    public virtual DbSet<Typeperson> Typepeople { get; set; }

    // public virtual DbSet<User> Users { get; set; }

    // public virtual DbSet<Userrol> Userrols { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // 2611
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
