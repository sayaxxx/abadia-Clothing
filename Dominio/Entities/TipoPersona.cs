namespace Dominio.Entities;

public class TipoPersona : BaseEntity{
    public string Nombre { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
}