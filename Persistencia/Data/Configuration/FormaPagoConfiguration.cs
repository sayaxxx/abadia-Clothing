using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class FormaPagoConfiguration : IEntityTypeConfiguration<FormaPago>{
    public void Configure(EntityTypeBuilder<FormaPago> builder){

        builder.ToTable("formaPago");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .IsRequired();
    }
}