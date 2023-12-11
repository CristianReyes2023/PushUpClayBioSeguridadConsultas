using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

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

    public virtual DbSet<Addressclient> Addressclients { get; set; }

    public virtual DbSet<Addressoffice> Addressoffices { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Programming> Programmings { get; set; }

    public virtual DbSet<Refreshtoken> Refreshtokens { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Statecontract> Statecontracts { get; set; }

    public virtual DbSet<Turn> Turns { get; set; }

    public virtual DbSet<Typeperson> Typepeople { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userrol> Userrols { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=campus2024;database=bioseguridaddb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Addressclient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("addressclient");

            entity.HasIndex(e => e.IdClientFk, "IdClientFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Bis)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bis");
            entity.Property(e => e.CardinalPrimario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_primario");
            entity.Property(e => e.CardinalSecundario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_secundario");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.IdTaddressFk).HasColumnName("IdTAddressFk");
            entity.Property(e => e.LetraPrincipal)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_principal");
            entity.Property(e => e.LetraSecundaria)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_secundaria");
            entity.Property(e => e.NumeroPrincipal).HasColumnName("numero_principal");
            entity.Property(e => e.NumeroSecundario).HasColumnName("numero_secundario");
            entity.Property(e => e.TipoVia)
                .HasMaxLength(50)
                .HasColumnName("tipo_via");

            entity.HasOne(d => d.IdClientFkNavigation).WithMany(p => p.Addressclients)
                .HasForeignKey(d => d.IdClientFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("addressclient_ibfk_1");
        });

        modelBuilder.Entity<Addressoffice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("addressoffice");

            entity.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Bis)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bis");
            entity.Property(e => e.CardinalPrimario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_primario");
            entity.Property(e => e.CardinalSecundario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_secundario");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.IdTaddressFk).HasColumnName("IdTAddressFk");
            entity.Property(e => e.LetraPrincipal)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_principal");
            entity.Property(e => e.LetraSecundaria)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_secundaria");
            entity.Property(e => e.NumeroPrincipal).HasColumnName("numero_principal");
            entity.Property(e => e.NumeroSecundario).HasColumnName("numero_secundario");
            entity.Property(e => e.TipoVia)
                .HasMaxLength(50)
                .HasColumnName("tipo_via");

            entity.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Addressoffices)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("addressoffice_ibfk_1");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("city");

            entity.HasIndex(e => e.IdStateFk, "IdStateFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameCity).HasMaxLength(50);

            entity.HasOne(d => d.IdStateFkNavigation).WithMany(p => p.Cities)
                .HasForeignKey(d => d.IdStateFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("city_ibfk_1");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client");

            entity.HasIndex(e => e.IdCityFk, "IdCityFk");

            entity.HasIndex(e => e.IdTpersonFk, "IdTPersonFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateRegister).HasColumnType("datetime");
            entity.Property(e => e.IdClient).HasMaxLength(50);
            entity.Property(e => e.IdTpersonFk).HasColumnName("IdTPersonFk");
            entity.Property(e => e.NameCliente).HasMaxLength(50);
            entity.Property(e => e.TelephoneNumber).HasMaxLength(11);

            entity.HasOne(d => d.IdCityFkNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdCityFk)
                .HasConstraintName("client_ibfk_1");

            entity.HasOne(d => d.IdTpersonFkNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdTpersonFk)
                .HasConstraintName("client_ibfk_2");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contract");

            entity.HasIndex(e => e.IdClientFk, "IdClientFk");

            entity.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            entity.HasIndex(e => e.IdStateContractFk, "IdStateContractFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateContract).HasColumnType("datetime");
            entity.Property(e => e.Datefinal)
                .HasColumnType("datetime")
                .HasColumnName("DATEFINAL");

            entity.HasOne(d => d.IdClientFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdClientFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_3");

            entity.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_2");

            entity.HasOne(d => d.IdStateContractFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdStateContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_1");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("country");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameCountry).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.IdCityFk, "IdCityFk");

            entity.HasIndex(e => e.IdPositionFk, "IdPositionFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateRegister).HasColumnType("datetime");
            entity.Property(e => e.IdEmployee).HasMaxLength(50);
            entity.Property(e => e.NameEmployee).HasMaxLength(50);
            entity.Property(e => e.TelephoneNumber).HasMaxLength(11);

            entity.HasOne(d => d.IdCityFkNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdCityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_ibfk_1");

            entity.HasOne(d => d.IdPositionFkNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdPositionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_ibfk_2");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("position");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NamePosition).HasMaxLength(50);
        });

        modelBuilder.Entity<Programming>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("programming");

            entity.HasIndex(e => e.IdContractFk, "IdContractFk");

            entity.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            entity.HasIndex(e => e.IdTurnFk, "IdTurnFk");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdContractFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_1");

            entity.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_3");

            entity.HasOne(d => d.IdTurnFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdTurnFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_2");
        });

        modelBuilder.Entity<Refreshtoken>(entity =>
        {
            entity.HasKey(e => e.RefreshTokenId).HasName("PRIMARY");

            entity.ToTable("refreshtoken");

            entity.Property(e => e.RefreshTokenId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Expires).HasColumnType("datetime");
            entity.Property(e => e.Revoked).HasColumnType("datetime");
            entity.Property(e => e.Token).HasMaxLength(255);

            entity.HasOne(d => d.RefreshToken).WithOne(p => p.Refreshtoken)
                .HasForeignKey<Refreshtoken>(d => d.RefreshTokenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("refreshtoken_ibfk_1");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PRIMARY");

            entity.ToTable("rol");

            entity.Property(e => e.RolId).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("state");

            entity.HasIndex(e => e.IdCountryFk, "IdCountryFk");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NameState).HasMaxLength(50);

            entity.HasOne(d => d.IdCountryFkNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.IdCountryFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("state_ibfk_1");
        });

        modelBuilder.Entity<Statecontract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("statecontract");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
        });

        modelBuilder.Entity<Turn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("turns");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.HourShiftFinally).HasColumnType("time");
            entity.Property(e => e.HourShiftStart).HasColumnType("time");
            entity.Property(e => e.NameTurns).HasMaxLength(50);
        });

        modelBuilder.Entity<Typeperson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("typeperson");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<Userrol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("userrol");

            entity.HasIndex(e => e.RolId, "RolId");

            entity.HasIndex(e => e.UsuarioId, "UsuarioId");

            entity.HasOne(d => d.Rol).WithMany()
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("userrol_ibfk_2");

            entity.HasOne(d => d.Usuario).WithMany()
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("userrol_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
