using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>{
    public void Configure(EntityTypeBuilder<Prenda> builder){

        builder.ToTable("prenda");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .IsRequired();

        builder.Property(p => p.ValorUnitCop)
        .IsRequired();

        builder.Property(p => p.ValorUnitUsd)
        .IsRequired();

        builder.HasOne(r => r.Estado)
        .WithMany(r => r.Prendas)
        .HasForeignKey(r => r.IdEstado);

        builder.HasOne(r => r.TipoProteccion)
        .WithMany(r => r.Prendas)
        .HasForeignKey(r => r.IdTipoProteccion);

        builder.HasOne(r => r.Genero)
        .WithMany(r => r.Prendas)
        .HasForeignKey(r => r.IdGenero);     
        
        builder
        .HasMany(i => i.Insumos) //1
        .WithMany(p => p.Prendas) //2
        .UsingEntity<InsumoPrenda>(
            j => j
            //1
            .HasOne(pt => pt.Insumo) // De intermedia
            .WithMany(t => t.InsumoPrenda) // De 1
            .HasForeignKey(ut => ut.IdPrenda), // De intermedia
            j => j
            //2
            .HasOne(et => et.Prenda) // De intermedia
            .WithMany(et => et.InsumoPrenda) // De 2
            .HasForeignKey(el => el.IdInsumo), // De intermedia
            j =>
            {
                j.ToTable("InsumoPrenda"); // Nombre intermedia
                j.HasKey(t => new { t.IdInsumo, t.IdPrenda }); // De intermedia

            });   
    }
}