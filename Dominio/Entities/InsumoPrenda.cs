namespace Dominio.Entities;

public class InsumoPrenda : BaseEntity {
    public int Cantidad { get; set; }

    // ID FORANEO DE TABLA 1
    public int IdInsumo { get; set; }
    // TABLA 1
    public Insumo Insumo { get; set; }
    //ID FORANEO TABLA 2
    public int IdPrenda { get; set; }
    // TABLA 2
    public Prenda Prenda { get; set; }
}
