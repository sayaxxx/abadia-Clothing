namespace Dominio.Entities;

public class InventarioTalla : BaseEntity{
    // ID FORANEO DE TABLA 1
    public int IdInv { get; set; }
    // TABLA 1
    public Inventario Inventario { get; set; }
    //ID FORANEO TABLA 2
    public int IdTalla { get; set; }
    // TABLA 2
    public Talla Talla { get; set; }
}