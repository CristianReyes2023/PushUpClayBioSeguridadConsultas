using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TypePersonConfiguration : IEntityTypeConfiguration<TypePerson>
    {
        public void Configure(EntityTypeBuilder<TypePerson> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("typeperson");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Description).HasColumnType("text");
        }
    }
}