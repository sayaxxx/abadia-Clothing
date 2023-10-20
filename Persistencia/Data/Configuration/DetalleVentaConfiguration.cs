using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder){

        builder.ToTable("detalleVenta");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Cantidad)
        .HasColumnName("cantidad")
        .IsRequired();

        builder.Property(p => p.ValorUnit)
        .HasColumnName("valorUnit")
        .IsRequired();
        
        builder.HasOne(r => r.Venta)
        .WithMany(r => r.DetalleVentas)
        .HasForeignKey(r => r.IdVenta);

        builder.HasOne(r => r.Inventario)
        .WithMany(r => r.DetalleVentas)
        .HasForeignKey(r => r.IdProducto);

        builder.HasOne(r => r.Talla)
        .WithMany(r => r.DetalleVentas)
        .HasForeignKey(r => r.IdTalla);
    
    }
}