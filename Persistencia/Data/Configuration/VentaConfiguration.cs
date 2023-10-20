using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class VentaConfiguration : IEntityTypeConfiguration<Venta>{
    public void Configure(EntityTypeBuilder<Venta> builder){

        builder.ToTable("venta");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Fecha)
        .IsRequired();

        builder.HasOne(r => r.Empleado)
        .WithMany(r => r.Ventas)
        .HasForeignKey(r => r.IdEmpleado);
        
        builder.HasOne(r => r.Cliente)
        .WithMany(r => r.Ventas)
        .HasForeignKey(r => r.IdCliente);

        builder.HasOne(r => r.FormaPago)
        .WithMany(r => r.Ventas)
        .HasForeignKey(r => r.IdFormaPago);
    }
}