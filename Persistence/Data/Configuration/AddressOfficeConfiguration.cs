using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AddressOfficeConfiguration : IEntityTypeConfiguration<AddressOffice>
    {
        public void Configure(EntityTypeBuilder<AddressOffice> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("addressoffice");

            builder.HasIndex(e => e.IdEmployeeFk, "IdEmployeeFk");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Bis)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bis");
            builder.Property(e => e.CardinalPrimario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_primario");
            builder.Property(e => e.CardinalSecundario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal_secundario");
            builder.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            builder.Property(e => e.IdTaddressFk).HasColumnName("IdTAddressFk");
            builder.Property(e => e.LetraPrincipal)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_principal");
            builder.Property(e => e.LetraSecundaria)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra_secundaria");
            builder.Property(e => e.NumeroPrincipal).HasColumnName("numero_principal");
            builder.Property(e => e.NumeroSecundario).HasColumnName("numero_secundario");
            builder.Property(e => e.TipoVia)
                .HasMaxLength(50)
                .HasColumnName("tipo_via");

            builder.HasOne(d => d.IdEmployeeFkNavigation).WithMany(p => p.Addressoffices)
                .HasForeignKey(d => d.IdEmployeeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("addressoffice_ibfk_1");
        }
    }
}