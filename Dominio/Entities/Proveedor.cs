namespace Dominio.Entities;

public class Proveedor : BaseEntity {
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; }

    //HASHSET TABLA DESTINO
    public ICollection<Insumo> Insumos { get; set; } = new HashSet<Insumo>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
}
