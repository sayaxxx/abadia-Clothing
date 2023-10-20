using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CargoConfiguration : IEntityTypeConfiguration<Cargo>{
    public void Configure(EntityTypeBuilder<Cargo> builder){

        builder.ToTable("cargo");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .IsRequired();

        builder.Property(p => p.SueldoBase)
        .IsRequired();
    }
}