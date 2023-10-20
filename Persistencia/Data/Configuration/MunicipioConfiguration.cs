using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>{
    public void Configure(EntityTypeBuilder<Municipio> builder){

        builder.ToTable("municipio");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.HasOne(r => r.Departamento)
        .WithMany(r => r.Municipios)
        .HasForeignKey(r => r.IdDep);
    }
}