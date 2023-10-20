using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TallaConfiguration : IEntityTypeConfiguration<Talla>{
    public void Configure(EntityTypeBuilder<Talla> builder){

        builder.ToTable("talla");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descripcion)
        .HasColumnName("descripcion")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

         builder
        .HasMany(i => i.Inventarios) //1
        .WithMany(p => p.Tallas) //2
        .UsingEntity<InventarioTalla>(
            j => j
            //1
            .HasOne(pt => pt.Inventario) // De intermedia
            .WithMany(t => t.InventarioTalla) // De 1
            .HasForeignKey(ut => ut.IdInv), // De intermedia
            j => j
            //2
            .HasOne(et => et.Talla) // De intermedia
            .WithMany(et => et.InventarioTalla) // De 2
            .HasForeignKey(el => el.IdInv), // De intermedia
            j =>
            {
                j.ToTable("InventarioTalla"); // Nombre intermedia
                j.HasKey(t => new { t.IdTalla, t.IdInv }); // De intermedia

            });
    }
}