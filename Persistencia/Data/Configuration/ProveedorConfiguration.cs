using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>{
    public void Configure(EntityTypeBuilder<Proveedor> builder){

        builder.ToTable("proveedor");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.NitProveedor)
        .IsRequired();

        builder.HasOne(r => r.TipoPersona)
        .WithMany(r => r.Proveedores)
        .HasForeignKey(r => r.IdTipoPersona);

        builder.HasOne(r => r.Municipio)
        .WithMany(r => r.Proveedores)
        .HasForeignKey(r => r.IdMunicipio);

         builder
        .HasMany(i => i.Insumos)
        .WithMany(p => p.Proveedores)
        .UsingEntity<InsumoProveedor>(
            j => j
            //1
            .HasOne(pt => pt.Insumo)
            .WithMany(t => t.InsumoProveedor)
            .HasForeignKey(ut => ut.IdProveedor),
            j => j
            //2
            .HasOne(et => et.Proveedor)
            .WithMany(et => et.InsumoProveedores)
            .HasForeignKey(el => el.IdInsumo),
            j =>
            {
                j.ToTable("InsumoProveedor");
                j.HasKey(t => new { t.IdInsumo, t.IdProveedor });
            });
    }
}