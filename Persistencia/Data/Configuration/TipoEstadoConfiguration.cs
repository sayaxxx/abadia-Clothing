using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>{
    public void Configure(EntityTypeBuilder<TipoEstado> builder){

        builder.ToTable("tipoEstado");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .IsRequired();
    }
}