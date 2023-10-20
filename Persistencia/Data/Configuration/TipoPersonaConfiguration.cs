using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>{
    public void Configure(EntityTypeBuilder<TipoPersona> builder){

        builder.ToTable("tipoPersona");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .IsRequired();
    }
}