using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>{
    public void Configure(EntityTypeBuilder<TipoProteccion> builder){

        builder.ToTable("tipoProteccion");

        builder.Property(p => p.Descripcion)
        .HasColumnName("descripcion")
        .IsRequired();

        
    }
}