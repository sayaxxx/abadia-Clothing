using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>{
    public void Configure(EntityTypeBuilder<Empleado> builder){

        builder.ToTable("empleado");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.FechaIngreso)
        .IsRequired();

        builder.HasOne(r => r.Cargo)
        .WithMany(r => r.Empleados)
        .HasForeignKey(r => r.IdCargo);

        builder.HasOne(r => r.Municipio)
        .WithMany(r => r.Empleados)
        .HasForeignKey(r => r.IdMunicipio);
    }
}