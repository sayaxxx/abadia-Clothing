namespace Dominio.Entities;

public class Inventario : BaseEntity{
    public int CodInv { get; set; }
    public int IdPrenda { get; set; }
    //UNA PRENDA TIENE MUCHO INVENTARIO
    public Prenda Prenda { get; set; }
    public int ValorVtaCop { get; set; }
    public int ValorVtaUsd { get; set; }

    //HASHSET TABLA DESTINO
    public ICollection<Talla> Tallas { get; set; } = new HashSet<Talla>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InventarioTalla> InventarioTalla { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; }
}
