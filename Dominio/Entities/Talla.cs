namespace Dominio.Entities;

public class Talla : BaseEntity {
    public string Descripcion { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; }
    
    //HASHSET TABLA DESTINO
    public ICollection<Inventario> Inventarios { get; set; } = new HashSet<Inventario>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InventarioTalla> InventarioTalla { get; set; }
}

