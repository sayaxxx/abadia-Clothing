namespace Dominio.Entities;

public class Insumo : BaseEntity {
    public string Nombre { get; set; }
    public int ValorUnit { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }

    //HASHSET TABLA DESTINO
    public ICollection<Proveedor> Proveedores { get; set; } = new HashSet<Proveedor>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InsumoProveedor> InsumoProveedor { get; set; }

    
    //HASHSET TABLA DESTINO
    public ICollection<Prenda> Prendas { get; set; } = new HashSet<Prenda>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InsumoPrenda> InsumoPrenda { get; set; }
}
