using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<Refreshtoken>
    {
        public void Configure(EntityTypeBuilder<Refreshtoken> builder)
        {
            builder.HasKey(e => e.RefreshTokenId).HasName("PRIMARY");

            builder.ToTable("refreshtoken");

            builder.Property(e => e.RefreshTokenId).ValueGeneratedNever();
            builder.Property(e => e.Created).HasColumnType("datetime");
            builder.Property(e => e.Expires).HasColumnType("datetime");
            builder.Property(e => e.Revoked).HasColumnType("datetime");
            builder.Property(e => e.Token).HasMaxLength(255);

            builder.HasOne(d => d.RefreshToken).WithOne(p => p.Refreshtoken)
                .HasForeignKey<Refreshtoken>(d => d.RefreshTokenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("refreshtoken_ibfk_1");
        }
    }
}