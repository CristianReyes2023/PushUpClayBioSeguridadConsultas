using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("client");

            builder.HasIndex(e => e.Id, "Id").IsUnique();

            builder.HasIndex(e => e.IdCityFk, "IdCityFk");

            builder.HasIndex(e => e.IdTpersonFk, "IdTPersonFk");

            builder.Property(e => e.DateRegister).HasColumnType("datetime");
            builder.Property(e => e.IdClient)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.IdTpersonFk).HasColumnName("IdTPersonFk");
            builder.Property(e => e.NameCliente)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.TelephoneNumber)
                .IsRequired()
                .HasMaxLength(11);

            builder.HasOne(d => d.IdCityFkNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdCityFk)
                .HasConstraintName("client_ibfk_1");

            builder.HasOne(d => d.IdTpersonFkNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdTpersonFk)
                .HasConstraintName("client_ibfk_2");
        }
    }
}