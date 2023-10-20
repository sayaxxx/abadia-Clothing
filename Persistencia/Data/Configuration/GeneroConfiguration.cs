using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>{
    public void Configure(EntityTypeBuilder<Genero> builder){

        builder.ToTable("genero");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .IsRequired();
    }
}