using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>{
    public void Configure(EntityTypeBuilder<Cliente> builder){

        builder.ToTable("cliente");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .IsRequired();
        
        builder.Property(p => p.FechaRegistro)
        .IsRequired();

        builder.HasOne(r => r.TipoPersona)
        .WithMany(r => r.Clientes)
        .HasForeignKey(r => r.IdTipoPersona);

        builder.HasOne(r => r.Municipio)
        .WithMany(r => r.Clientes)
        .HasForeignKey(r => r.IdMunicipio);
    }
}