using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class EstadoConfiguration : IEntityTypeConfiguration<Estado>{
    public void Configure(EntityTypeBuilder<Estado> builder){

        builder.ToTable("estado");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)

        .IsRequired();

        builder.HasOne(r => r.TipoEstado)
        .WithMany(r => r.Estados)
        .HasForeignKey(r => r.IdTipoEstado);
    }
}