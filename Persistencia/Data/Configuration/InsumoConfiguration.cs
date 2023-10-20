using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>{
    public void Configure(EntityTypeBuilder<Insumo> builder){

        builder.ToTable("insumo");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.ValorUnit)
        .HasColumnName("ValorUnit")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.StockMin)
        .HasColumnName("StockMin")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.StockMax)
        .HasColumnName("StockMax")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder
        .HasMany(i => i.Proveedores)
        .WithMany(p => p.Insumos)
        .UsingEntity<InsumoProveedor>(
            j => j
            .HasOne(pt => pt.Proveedor)
            .WithMany(t => t.InsumoProveedores)
            .HasForeignKey(ut => ut.IdProveedor),
            j => j
            .HasOne(et => et.Insumo)
            .WithMany(et => et.InsumoProveedor)
            .HasForeignKey(el => el.IdInsumo),
            j =>
            {
                j.ToTable("InsumoProveedor");
                j.HasKey(t => new { t.IdInsumo, t.IdProveedor });

            });

        builder
        .HasMany(i => i.Prendas)
        .WithMany(p => p.Insumos)
        .UsingEntity<InsumoPrenda>(
            j => j
            .HasOne(pt => pt.Prenda)
            .WithMany(t => t.InsumoPrenda)
            .HasForeignKey(ut => ut.IdPrenda),
            j => j
            .HasOne(et => et.Insumo)
            .WithMany(et => et.InsumoPrenda)
            .HasForeignKey(el => el.IdInsumo),
            j =>
            {
                j.ToTable("InsumoPrenda");
                j.HasKey(t => new { t.IdInsumo, t.IdPrenda });

            });
    }
}