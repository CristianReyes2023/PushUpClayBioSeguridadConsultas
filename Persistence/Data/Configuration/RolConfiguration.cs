using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasKey(e => e.RolId).HasName("PRIMARY");

            builder.ToTable("rol");

            builder.Property(e => e.RolId).ValueGeneratedNever();
            builder.Property(e => e.Nombre).HasMaxLength(255);
        }
    }
}