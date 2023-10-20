namespace Dominio.Entities;

public class Empresa : BaseEntity {
    public int Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int IdMun { get; set; }
    public Municipio Municipio { get; set; }
}