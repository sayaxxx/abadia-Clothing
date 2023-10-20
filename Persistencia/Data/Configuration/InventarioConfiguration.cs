using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("inventario");

        builder.HasOne(p => p.Prenda)
        .WithMany(m => m.Inventarios)
        .HasForeignKey(p => p.IdPrenda);

        builder
        .HasMany(i => i.Tallas)
        .WithMany(p => p.Inventarios)
        .UsingEntity<InventarioTalla>(
            j => j

            .HasOne(pt => pt.Talla)
            .WithMany(t => t.InventarioTalla) 
            .HasForeignKey(ut => ut.IdTalla), 
            j => j

            .HasOne(et => et.Inventario) 
            .WithMany(et => et.InventarioTalla)
            .HasForeignKey(el => el.IdInv),
            j =>
            {
                j.ToTable("InventarioTalla");
                j.HasKey(t => new { t.IdTalla, t.IdInv });

            });
    }
}