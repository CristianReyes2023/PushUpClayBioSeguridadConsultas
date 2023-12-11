using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("employee");

            builder.HasIndex(e => e.IdCityFk, "IdCityFk");

            builder.HasIndex(e => e.IdPositionFk, "IdPositionFk");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.DateRegister).HasColumnType("datetime");
            builder.Property(e => e.IdEmployee).HasMaxLength(50);
            builder.Property(e => e.NameEmployee).HasMaxLength(50);
            builder.Property(e => e.TelephoneNumber).HasMaxLength(11);

            builder.HasOne(d => d.IdCityFkNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdCityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_ibfk_1");

            builder.HasOne(d => d.IdPositionFkNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdPositionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_ibfk_2");
        }
    }
}