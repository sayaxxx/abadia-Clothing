namespace Dominio.Entities;

public class Cliente : BaseEntity{
    public ICollection<Venta> Ventas { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TipoPersona { get; set;}
    public DateTime FechaRegistro { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; } 
    public ICollection<Orden> Ordenes { get; set; }
}