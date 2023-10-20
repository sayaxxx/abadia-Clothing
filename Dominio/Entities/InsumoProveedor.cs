namespace Dominio.Entities;

public class InsumoProveedor : BaseEntity{
    // ID FORANEO DE TABLA 1
    public int IdInsumo { get; set; }
    // TABLA 1
    public Insumo Insumo { get; set; }
    //ID FORANEO TABLA 2
    public int IdProveedor { get; set; }
    // TABLA 2
    public Proveedor Proveedor { get; set; }
}