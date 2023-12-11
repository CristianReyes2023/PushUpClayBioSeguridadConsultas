using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProgrammingConfiguration : IEntityTypeConfiguration<Programming>
    {
        public void Configure(EntityTypeBuilder<Programming> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("programming");

            builder.HasIndex(e => e.IdContractFk, "IdContractFk");

            builder.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            builder.HasIndex(e => e.IdTurnFk, "IdTurnFk");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.IdContractFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdContractFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_1");

            builder.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_3");

            builder.HasOne(d => d.IdTurnFkNavigation).WithMany(p => p.Programmings)
                .HasForeignKey(d => d.IdTurnFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("programming_ibfk_2");
        }
    }
}