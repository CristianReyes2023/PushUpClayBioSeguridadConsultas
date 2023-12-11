using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId).HasName("PRIMARY");

            builder.ToTable("user");

            builder.Property(e => e.UserId).ValueGeneratedNever();
            builder.Property(e => e.Email).HasMaxLength(255);
            builder.Property(e => e.Password).HasMaxLength(255);
            builder.Property(e => e.Username).HasMaxLength(255);
        }
    }
}