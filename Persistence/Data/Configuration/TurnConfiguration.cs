using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TurnConfiguration : IEntityTypeConfiguration<Turn>
    {
        public void Configure(EntityTypeBuilder<Turn> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("turns");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.HourShiftFinally).HasColumnType("time");
            builder.Property(e => e.HourShiftStart).HasColumnType("time");
            builder.Property(e => e.NameTurns).HasMaxLength(50);
        }
    }
}