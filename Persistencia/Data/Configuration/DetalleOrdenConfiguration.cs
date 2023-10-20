using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleOrdenConfigurationConfiguration : IEntityTypeConfiguration<DetalleOrden>{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder){

        builder.ToTable("detalleConfiguration");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.CantidadProducir)
        .IsRequired();

        builder.Property(p => p.CantidadProducida)
        .IsRequired();

        builder.HasOne(r => r.Orden)
        .WithMany(r => r.DetalleOrdenes)
        .HasForeignKey(r => r.IdOrden);
        
        builder.HasOne(r => r.Prenda)
        .WithMany(r => r.DetalleOrdenes)
        .HasForeignKey(r => r.IdPrenda);

        builder.HasOne(r => r.Color)
        .WithMany(r => r.DetalleOrdenes)
        .HasForeignKey(r => r.IdColor);
        
        builder.HasOne(r => r.Estado)
        .WithMany(r => r.DetalleOrdenes)
        .HasForeignKey(r => r.IdEstado);
    }
}