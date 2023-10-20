using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ColorConfiguration : IEntityTypeConfiguration<Color>{
    public void Configure(EntityTypeBuilder<Color> builder){

        builder.ToTable("color");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .IsRequired();
    }
}