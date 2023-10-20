using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>{
    public void Configure(EntityTypeBuilder<Empresa> builder){

        builder.ToTable("empresa");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nit)
        .IsRequired();

        builder.Property(p => p.RazonSocial)
        .IsRequired();

        builder.Property(p => p.RepresentanteLegal)
        .IsRequired();

        builder.Property(p => p.FechaCreacion)
        .IsRequired();

        builder.HasOne(r => r.Municipio)
        .WithMany(r => r.Empresas)
        .HasForeignKey(r => r.IdMun);
    }
}