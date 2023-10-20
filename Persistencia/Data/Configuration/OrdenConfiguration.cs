using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>{
    public void Configure(EntityTypeBuilder<Orden> builder){

        builder.ToTable("orden");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Fecha)
        .IsRequired();

        builder.HasOne(r => r.Empleado)
        .WithMany(r => r.Ordenes)
        .HasForeignKey(r => r.IdEmpleado);
        
        builder.HasOne(r => r.Cliente)
        .WithMany(r => r.Ordenes)
        .HasForeignKey(r => r.IdCliente);
        
        builder.HasOne(r => r.Estado)
        .WithMany(r => r.Ordenes)
        .HasForeignKey(r => r.IdEstado);
    }
}