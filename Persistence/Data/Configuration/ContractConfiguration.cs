using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contract");

            builder.HasIndex(e => e.IdClientFk, "IdClientFk");

            builder.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            builder.HasIndex(e => e.IdStateContractFk, "IdStateContractFk");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.DateContract).HasColumnType("datetime");
            builder.Property(e => e.Datefinal)
                .HasColumnType("datetime")
                .HasColumnName("DATEFINAL");

            builder.HasOne(d => d.IdClientFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdClientFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_3");

            builder.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_2");

            builder.HasOne(d => d.IdStateContractFkNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdStateContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contract_ibfk_1");
        }
    }
}