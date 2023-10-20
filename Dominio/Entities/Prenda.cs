namespace Dominio.Entities;

public class Prenda : BaseEntity{
    public int IdPrenda { get; set; }
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    public string Nombre { get; set; }
    public int ValorUnitCop { get; set; }
    public int ValorUnitUsd { get; set; }
    public int IdEstado { get; set; }
    public Estado Estado { get; set; }
    public int IdTipoProteccion { get; set; }
    public TipoProteccion TipoProteccion { get; set; }
    public int IdGenero { get; set; }
    public Genero Genero { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }

    //HASHSET TABLA DESTINO
    public ICollection<Insumo> Insumos { get; set; } = new HashSet<Insumo>();
    //COLECCION TABLA INTERMEDIA
    public ICollection<InsumoPrenda> InsumoPrenda { get; set; }
}

// FALTAN FK IdEstado
//FK IdTipoProteccion
//FK idGenero